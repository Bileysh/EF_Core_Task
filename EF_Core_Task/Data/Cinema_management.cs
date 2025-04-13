using EF_Core_Task.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace EF_Core_Task.Data
{
    public class Cinema_management : DbContext
    {
        DbSet<Movie> Movies { get; set; }
        DbSet<Hall> Halls { get; set; }
        DbSet<Session> Sessions { get; set; }
        DbSet<Ticket> Tickets { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Sales> Sales { get; set; }
        DbSet<Discount> Discounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Cinema;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
