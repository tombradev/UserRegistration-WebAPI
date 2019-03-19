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
         * This to setting up the database connection
         */

        public AuthenticationContext(DbContextOptions options) : base (options) // <- PASSING THE SAME PARAMETER TO THE PARRENT
        {

        }
    }
}
