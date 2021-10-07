using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FabricaRoupa.Models
{
    [Table("Roupa")]
    public class Roupa
    {
        [Key]
        [Column("idroupa")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public Int32 IdRoupa { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10 ,ErrorMessage = "O valor deve ser de 10 á 50 caracteres")]
        [Column("nome")]

        public string Nome { get; set; }

        [Column("preco")]
        [Required(ErrorMessage = " O campo é obrigatório ")]

        public decimal Preco { get; set; }


        [Column("medida")]
        [Required(ErrorMessage = " O campo é obrigatório ")]

        public decimal Medida { get; set; }
    }
}
