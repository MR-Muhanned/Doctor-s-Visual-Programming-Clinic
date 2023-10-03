using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR.model
{
    internal class dbContext : DbContext
    {

        public DbSet<Receiving1> Receivings { get; set; }
        public DbSet<Prescription1> prescriptions { get; set; }
        public DbSet<PrescriptionDDD> prescriptionDDDs { get; set; }
        public DbSet<Diag> diagnosis { get; set; }
        public DbSet<login> login { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=Muhannad\SQLEXPRESS01;Initial Catalog=drre;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
