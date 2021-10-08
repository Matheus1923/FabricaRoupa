using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FabricaRoupa.Models
{
    [Table("Venda")]
    public class Venda
    {
        [Key]
        [Column("idvenda")]
        [Required(ErrorMessage = "O campo deve ser obrigatório")]

        public Int32 IdVenda { get; set; }

        [Column("idfuncionario")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public int IdFuncionario { get; set; }

        [Column("idloja")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public int IdLoja { get; set; }

        [Column("IdRoupa")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public int IdRoupa { get; set; }
    }
}
