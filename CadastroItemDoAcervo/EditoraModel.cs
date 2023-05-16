using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroItemDoAcervo
{
    [Table("mvtBibEditora")]
    public class EditoraModel
    {
        [Key()]
        public int CodEditora { get; set; }

        public string NomeEditora { get; set; }
    }
}
