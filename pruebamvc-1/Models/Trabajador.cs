using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pruebamvc_1.Models
{
    public class Trabajador
    {
        [Key]
        public int idtrabajador { get; set; }


        [Column(TypeName = "nvarchar(20)")]
        [Required]
        [DisplayName("Tipo de identificacion")]
        public string tipoidentificacion { get; set; }
        [Required]
        [DisplayName("Identificacion")]
        public int identificacion { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Primer Nombre")]
        public string pr_nombre { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Segundo Nombre")]
        public string seg_nombre { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Primer Apellido")]
        public string pr_apellido { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Segundo Apellido")]
        public string seg_apellido { get; set; }

        [DataType(DataType.Date)]
        [Required]
        [DisplayName("Fecha Nacimiento")]
        public DateTime fecha_nacimiento { get; set; }
        [DisplayName("Edad")]
        public int edad { get {
                DateTime now=DateTime.Today;
                int edad= DateTime.Today.Year - fecha_nacimiento.Year;
                if (DateTime.Today < fecha_nacimiento.AddYears(edad)){
                    return --edad;
                }
                else
                {
                    return edad;
                }
            } }
    }
    
}
