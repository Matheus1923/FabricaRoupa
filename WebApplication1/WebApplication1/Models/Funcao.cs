using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FabricaRoupa.Models
{
    [Table("Funcao")]
    public class Funcao
    {
        [Key]
        [Column("idfuncao")]
        [Required(ErrorMessage = "O valor do campo é obrigatório")]

        public Int32 IdFuncao { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O valor deve ser de 10 á 50 caracteres")]
        [Column("nome")]

        public string Nome { get; set; }

    }
}
