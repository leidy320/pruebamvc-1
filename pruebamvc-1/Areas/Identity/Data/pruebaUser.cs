using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebamvc_1.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the pruebaUser class
    public class pruebaUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string primer_nombre { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string segun_nombre { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string primer_apellido { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string segun_apellido { get; set; }
    }
}
