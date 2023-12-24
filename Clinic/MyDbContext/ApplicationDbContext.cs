using Clinic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DbContext 
{
    internal class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TF2CRSH;Initial Catalog=Clinic_system;Integrated Security=True;TrustServerCertificate=True;");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patients> Patient { get; set; }
        public DbSet<Registration> Registration { get; set; }
        public DbSet<Specialization> Specialization { get; set; }

    }
}
