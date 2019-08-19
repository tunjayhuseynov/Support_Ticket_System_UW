using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Upwork_2019_08_08.Models;

namespace Upwork_2019_08_08.Data
{
    public class SystemContext : DbContext
    {
        public SystemContext(DbContextOptions<SystemContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<LogHistorie> LogHistories { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AmAndClient> AmAndClients { get; set; }
        public DbSet<DepartamentUser> DepartamentUsers { get; set; }
        public DbSet<AmUser> AmUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Departament>().ToTable("Departaments");
            modelBuilder.Entity<Feedback>().ToTable("Feedbacks");
            modelBuilder.Entity<LogHistorie>().ToTable("LogHistories");
            modelBuilder.Entity<Ticket>().ToTable("Tickets");
            modelBuilder.Entity<Message>().ToTable("Messages");
            modelBuilder.Entity<Admin>().ToTable("Admins");
            modelBuilder.Entity<AmAndClient>().ToTable("AmAndClients");
            modelBuilder.Entity<DepartamentUser>().ToTable("DepartamentUsers");
            modelBuilder.Entity<AmUser>().ToTable("AmUsers");
        }
    }
}
