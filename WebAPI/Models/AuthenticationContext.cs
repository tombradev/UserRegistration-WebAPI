using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class AuthenticationContext : IdentityDbContext
    {
        /*
         * wHAT IS THIS CONTEXT?
         * This to setting up the database connection configurations
         */

        public AuthenticationContext(DbContextOptions options) : base (options) // <- PASSING THE SAME PARAMETER TO THE PARRENT
        {
            
        }

        /*
         * Mentioned the costumizatiion data types and properties into database
         * Creating the custom entity types for user
         */

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }    //entity type of User
    }
}
