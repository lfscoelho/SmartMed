using AutoMapper;
using SmartMed.Application.ViewModels;
using SmartMed.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMed.API.Configurations
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Medication, MedicationViewModel>();
        }
    }
}
