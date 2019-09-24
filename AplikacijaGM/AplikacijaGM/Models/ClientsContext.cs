using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacijaGM.Models
{
    public class ClientsContext:DbContext
    {
        public ClientsContext(DbContextOptions<ClientsContext> options):base(options)
        {
        }

        public DbSet<Clients> Clients { get; set; }
    }
}
