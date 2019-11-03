using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartMed.Application.ViewModels
{
    public class MedicationViewModel
    {
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a value bigger than {1}.")]
        public int Quantity { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
