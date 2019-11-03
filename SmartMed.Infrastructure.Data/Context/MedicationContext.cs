using Microsoft.EntityFrameworkCore;
using SmartMed.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMed.Infrastructure.Data.Context
{
    public class MedicationContext : DbContext
    {
        public MedicationContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Medication> Medications { get; set; }
    }
}
