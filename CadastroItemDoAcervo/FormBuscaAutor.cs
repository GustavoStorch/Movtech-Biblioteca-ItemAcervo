﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroItemDoAcervo
{
    public partial class FormBuscaAutor : Form
    {

        public string nomeAutor { get; private set; }


        public FormBuscaAutor()
        {
            InitializeComponent();
        }

        private void FormBuscaAutor_Load(object sender, EventArgs e)
        {
            InitializeTable();
        }

        public void carregaTextBox()
        {
            nomeAutor = txtNomeAutor.Text;
            this.Close();
        }

        private void InitializeTable()
        {
            dtgDadosAutor.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                AutorDAO dao = new AutorDAO(connection);
                List<AutorModel> autores = dao.GetAutores();
                foreach (AutorModel autor in autores)
                {
                    DataGridViewRow row = dtgDadosAutor.Rows[dtgDadosAutor.Rows.Add()];
                    row.Cells[colCodAutor.Index].Value = autor.CodAutor;
                    row.Cells[colNomeAutor.Index].Value = autor.NomeAutor;
                }
            }
        }

        private void dtgDadosAutor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtNomeAutor.Text = dtgDadosAutor.Rows[e.RowIndex].Cells[colNomeAutor.Index].Value + "";
            }
            carregaTextBox();
        }

        private void btnSelectionar_Click(object sender, EventArgs e)
        {
            carregaTextBox();
        }

        private void txtNomeAutor_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeAutor.Text.Trim();

            foreach (DataGridViewRow row in dtgDadosAutor.Rows)
            {
                string nomeAutor = row.Cells[colNomeAutor.Index].Value.ToString().Trim();

                // Verifica se o nome do autor contém o filtro
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;

                // Define a visibilidade da linha com base no resultado do filtro
                row.Visible = exibir;
            }
        }
    }
}
