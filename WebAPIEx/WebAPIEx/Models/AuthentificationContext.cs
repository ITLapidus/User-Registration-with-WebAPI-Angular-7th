using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebAPIEx.Models
{
    public class AuthentificationContext : IdentityDbContext
    {
        public AuthentificationContext(DbContextOptions options) : base(options)
        {
                
        }
    }
}    