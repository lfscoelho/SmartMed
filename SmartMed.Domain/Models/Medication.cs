using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartMed.Domain.Models
{
    public class Medication
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a value bigger than {1}.")]
        public int Quantity { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
