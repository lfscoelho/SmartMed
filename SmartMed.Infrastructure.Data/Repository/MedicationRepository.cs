using Microsoft.EntityFrameworkCore;
using SmartMed.Domain.Interfaces;
using SmartMed.Domain.Models;
using SmartMed.Infrastructure.Data.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartMed.Infrastructure.Data.Repository
{
    public class MedicationRepository : IMedicationRepository
    {

        private MedicationContext context;

        public MedicationRepository(MedicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Medication> GetMedications()
        {
            return context.Medications.ToList();
        }
        public Medication GetMedicationByID(int medicationId)
        {
            return context.Medications.Find(medicationId);
        }

        public void InsertMedication(Medication medication)
        {
            context.Medications.Add(medication);
            context.SaveChanges();
        }

        public void DeleteMedication(int medicationId)
        {
            Medication medication = context.Medications.Find(medicationId);
            context.Medications.Remove(medication);
        }

        public void UpdateMedication(Medication medication)
        {
            context.Entry(medication).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

      
    }
}
