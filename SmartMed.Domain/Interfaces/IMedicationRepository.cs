using SmartMed.Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SmartMed.Domain.Interfaces
{
    public interface IMedicationRepository
    {
        IEnumerable<Medication> GetMedications();
        Medication GetMedicationByID(int medicationId);
        void InsertMedication(Medication medication);
        void DeleteMedication(int medicationId);
        void UpdateMedication(Medication medication);
        void Save();
    }
}
