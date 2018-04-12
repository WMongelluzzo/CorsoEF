using LabEF.ConsoleApp.Models;
using System.Data.Entity;

namespace LabEF.ConsoleApp.Data
{
    class FatturarioContext: DbContext
    {
        public FatturarioContext(): base("FatturarioDbConnection")
        {
        }

        public DbSet<Fattura> Fatture { get; set; }

        public DbSet<VoceFattura> VociFattura { get; set; }
    }
}
