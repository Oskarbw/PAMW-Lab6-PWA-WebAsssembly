using PWA_BlazorWebAssembly.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PWA_BlazorWebAssembly.DataAccess
{
    public class PostOfficeContext : DbContext
    {
        public DbSet<Parcel> Parcels { get; set; }

        public PostOfficeContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.\\DbPostOffice");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parcel>(eb =>
            {
                eb.HasKey(p => p.Id);
                eb.Property(p => p.Sender).HasColumnType("varchar(50)");
                eb.Property(p => p.Receiver).HasColumnType("varchar(50)").IsRequired();
                eb.HasData(new List<Parcel>
                {
                    new Parcel
                    {
                        Id = 1,
                        Sender = "Bob",
                        Receiver = "Ross",
                        Weight = 14
                    },
                    new Parcel
                    {
                        Id = 2,
                        Sender = "Miley",
                        Receiver = "Karen",
                        Weight = 17
                    }
                }
                );
            });

        }

    }
}
