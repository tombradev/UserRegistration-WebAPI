using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema; // this is used for creating custom data type that diffrent from default NVARCHAR(MAX)
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ApplicationUser : IdentityUser
    {

        /*
         * The Default data type is NVARCHAR(MAX), howerver its possible to change into the other type
         */
        [Column(TypeName = "nvarchar(150)")]
        public string FullName { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string FullName { get; set; }
    }
}
