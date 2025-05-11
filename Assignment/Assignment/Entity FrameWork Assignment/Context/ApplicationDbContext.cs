using Entity_FrameWork_Assignment.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Assignment.Context
{
    internal class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=Airport;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        DbSet<Airline> Airline { get; set; }
        DbSet<Flight> Flight { get; set; }
        DbSet<Passenger> Passenger { get; set; }
        DbSet<Baggage> Baggage { get; set; }
        DbSet<Officer> Officer { get; set; }
        DbSet<Terminal> Terminal { get; set; }
        DbSet<Gate> Gate { get; set; }
        DbSet<Checkpoint> Checkpoint { get; set; }
    }
}
