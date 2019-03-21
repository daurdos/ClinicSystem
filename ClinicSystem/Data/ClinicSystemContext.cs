using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClinicSystem.Models;

namespace ClinicSystem.Models
{
    public class ClinicSystemContext : DbContext
    {
        public ClinicSystemContext (DbContextOptions<ClinicSystemContext> options)
            : base(options)
        {
        }

        public DbSet<ClinicSystem.Models.Patient> Patient { get; set; }

        public DbSet<ClinicSystem.Models.Visit> Visit { get; set; }
    }
}
