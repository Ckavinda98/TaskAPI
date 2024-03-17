using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskApi.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Aurthor> Aurthors { get; set; }
        public DbSet<Todo> Todos { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-JJIU4T4; Database=MyToDoDB; User Id=sa; Password=12345; TrustServerCertificate=True;  MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aurthor>().HasData(new Aurthor[]
            {
              new Aurthor { Id= 1, FullName="Malith Fernandol", AddressNo="45", Street="Flower Road", City="Colombo" },
              new Aurthor { Id= 2, FullName="Kevin Aravinda", AddressNo="10", Street="Smaagi Road", City="Kaluthara"},
              new Aurthor { Id= 3, FullName="Dilina Supun", AddressNo="67", Street="Fifth lane", City="Gampaha"}

            });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
               new Todo { Id = 1,
                Title = "Example 1 - DB",
                Description = "Test",
                Created = DateTime.Now,
                Deu = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AurthorId = 1
                },

               new Todo { Id = 2,
                Title = "Example 2 - DB",
                Description = "Test",
                Created = DateTime.Now,
                Deu = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AurthorId = 3
                },

               new Todo { Id = 3,
                Title = "Example 3 - DB",
                Description = "Test",
                Created = DateTime.Now,
                Deu = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AurthorId = 2
                },

            });
        }
    }
}
