using SmartMed.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMed.Application.Interfaces
{
    public interface IMedicationService
    {
        IEnumerable<MedicationViewModel> GetMedications();
        MedicationViewModel GetMedicationByID(int medicationId);
        void InsertMedication(MedicationViewModel medication);
        void DeleteMedication(int medicationId);
        void UpdateMedication(MedicationViewModel medication);
    }
}
