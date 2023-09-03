using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace HireExpat.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
       



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

        }
    }
}
