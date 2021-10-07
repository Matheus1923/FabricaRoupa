using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FabricaRoupa.Models
{
    [Table("Setor")]
    public class Setor
    {
        [Key]
        [Column("idsetor")]
        [Required (ErrorMessage = "O campo é obrigatório")]

        public Int32 IdSetor { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser de 10 á 50")]
        [Column("nome")]

        public String Nome { get; set; }
    }
}
