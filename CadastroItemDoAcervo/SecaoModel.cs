using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroItemDoAcervo
{
    [Table("mvtBibSecao")]
    public class SecaoModel
    {
        [Key()]
        public int CodSecao { get; set; }

        public string DescricaoSecao { get; set; }
    }
}
