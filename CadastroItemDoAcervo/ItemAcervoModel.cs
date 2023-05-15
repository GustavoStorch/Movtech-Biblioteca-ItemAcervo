using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroItemDoAcervo
{
    [Table("mvtBibItemAcervo")]

    public class ItemAcervoModel
    {
        [Key()]
        public string CodItem { get; set; }

        public string NumExemplar { get; set; }

        public string Nome { get; set; }

        public string TipoItem { get; set; }

        public string Volume { get; set; }

        public string AnoEdicao { get; set; }

        public string Localizacao { get; set; }

        public string Idioma { get; set; }

        [ForeignKey("mvtBibAutor")]
        [Column("codAutor")]
        public string CodAutor { get; set; }

        public virtual AutorModel AutorModel { get; set; }

        [ForeignKey("mvtBibEditora")]
        [Column("codEditora")]
        public string CodEditora { get; set; }

        public virtual EditoraModel EditoraModel { get; set; }

        [ForeignKey("mvtBibLocal")]
        [Column("codLocal")]
        public string CodLocal { get; set; }

        public virtual LocalModel LocalModel { get; set; }

        [ForeignKey("mvtBibSecao")]
        [Column("codSecao")]
        public string CodSecao { get; set; }

        public virtual SecaoModel SecaoModel { get; set; }
    }
}
