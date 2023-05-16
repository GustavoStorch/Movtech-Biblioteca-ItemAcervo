using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroItemDoAcervo
{
    [Table("mvtBibLocal")]
    public class LocalModel
    {
        [Key()]
        public int CodLocal { get; set; }

        public string DescricaoLocal { get; set; }
    }
}
