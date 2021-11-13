using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDNI.Models;

namespace WebApiDNI.DataContext
{
    public class PersonContext:DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options):base(options)
        {
            
        }
        public DbSet<Person> Person { get; set; }
    }
}
