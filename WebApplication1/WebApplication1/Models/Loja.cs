using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FabricaRoupa.Models
{
    [Table("Loja")]
    public class Loja
    {
        [Key]
        [Column("idloja")]
        [Required (ErrorMessage = "O campo é obrigatório")]

        public Int32 IdLoja { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = " O campo deve ter no minimo 10 á 50 caracteres")]
        [Column("nome")]

        public string Nome { get; set; }

        [Column("credito")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public decimal Credito { get; set; }

    }
}
