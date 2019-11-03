using AutoMapper;
using SmartMed.Application.Interfaces;
using SmartMed.Application.ViewModels;
using SmartMed.Domain.Interfaces;
using SmartMed.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMed.Application.Services
{
    public class MedicationService : IMedicationService
    {
        private readonly IMedicationRepository _medicationRepository;
        private readonly IMapper _autoMapper;

        public MedicationService(IMedicationRepository medicationRepository, IMapper autoMapper)
        {
            _autoMapper = autoMapper;
            _medicationRepository = medicationRepository;
        }


        public void DeleteMedication(int medicationId)
        {
            _medicationRepository.DeleteMedication(medicationId);
        }

        public MedicationViewModel GetMedicationByID(int medicationId)
        {
            return _autoMapper.Map<MedicationViewModel>(_medicationRepository.GetMedicationByID(medicationId));
        }

        public IEnumerable<MedicationViewModel> GetMedications()
        {
            return _autoMapper.Map<IEnumerable<MedicationViewModel>>(_medicationRepository.GetMedications());
        }

        public void InsertMedication(MedicationViewModel medication)
        {
            var map = _autoMapper.Map<Medication>(medication);

            _medicationRepository.InsertMedication(map);
        }

        public void UpdateMedication(MedicationViewModel medication)
        {
            var map = _autoMapper.Map<Medication>(medication);

            _medicationRepository.UpdateMedication(map);
        }
    }
}
