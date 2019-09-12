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

        public DbSet<ClientUser> ClientUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<LogHistorie> LogHistories { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<AmAndDepartament> AmAndDepartaments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<AdminRole> AdminRoles { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Response> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientUser>().ToTable("ClientUsers");
            modelBuilder.Entity<Department>().ToTable("Departments");
            modelBuilder.Entity<AdminRole>().ToTable("AdminRoles");
            modelBuilder.Entity<Company>().ToTable("Companies");
            modelBuilder.Entity<Feedback>().ToTable("Feedbacks");
            modelBuilder.Entity<LogHistorie>().ToTable("LogHistories");
            modelBuilder.Entity<Ticket>().ToTable("Tickets");
            modelBuilder.Entity<Message>().ToTable("Messages");
            modelBuilder.Entity<AdminUser>().ToTable("AdminUsers");
            modelBuilder.Entity<AmAndDepartament>().ToTable("AmAndDepartaments");
            modelBuilder.Entity<ServiceRequest>().ToTable("ServiceRequests");
            modelBuilder.Entity<Detail>().ToTable("Details");
            modelBuilder.Entity<ServiceType>().ToTable("ServiceTypes");
            modelBuilder.Entity<Response>().ToTable("Responses");

        }
    }
}
