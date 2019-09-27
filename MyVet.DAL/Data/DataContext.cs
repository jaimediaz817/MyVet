
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyVet.DAL.Data.Entities;
using MyVet.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVet.DAL.Data
{
    public class DataContext: IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        // cuales enties vamos a mapear en la base de datos
        public DbSet<Agenda> Agendas{ get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Manager> Managers { get; set; }
    }
}
