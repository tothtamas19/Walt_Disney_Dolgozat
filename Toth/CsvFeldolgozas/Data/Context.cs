using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvFeldolgozas.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CsvFeldolgozas.Data
{
    public class Context:DbContext
    {
        public DbSet<CsvData> CsvData_stuff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CsvReading4WpfEx;Trusted_Connection=True;");
        }
    }
}
