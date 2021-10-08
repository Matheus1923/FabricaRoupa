using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FabricaRoupa.Models
{
    [Table("RoupaTecido")]
    public class RoupaTecido
    {
        [Key]
        [Column("idroupatecido")]
        [Required]

        public Int32 IdRoupaTecido { get; set; }

        [Column("idroupa")]
        [Required]

        public int IdRoupa { get; set; }

        [Column("IdTecido")]
        [Required]

        public int IdTecido { get; set; }

    }
}
