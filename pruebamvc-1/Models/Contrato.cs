using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pruebamvc_1.Models
{
    public class Contrato
    {
        [Key]
        public int idcontrato { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string nombre_entidad { get; set; }

        [Required]
        public int num_contrato { get; set; }

        [Column(TypeName = "nvarchar(200)")]
       
        public string trab_vinculado { get; set; }

        [DataType(DataType.Date)]
        [Required]
        

        public DateTime fecha_inicio { get; set; }


        [DataType(DataType.Date)]
        [Required]

        public DateTime fecha_final { get; set; }

    }
}
