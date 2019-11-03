using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartMed.Application.Interfaces;
using SmartMed.Application.ViewModels;

namespace SmartMed.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationController : ControllerBase
    {

        private readonly IMedicationService _medicationService;

        public MedicationController(IMedicationService medicationService)
        {
            _medicationService = medicationService;
        }


        [HttpPost]
        public IActionResult Post([FromBody] MedicationViewModel medicationViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _medicationService.InsertMedication(medicationViewModel);

            return Ok(medicationViewModel);
        }


        [HttpGet("GetMedications")]
        public IActionResult GetMedications()
        {
            _medicationService.GetMedications();

            return Ok(_medicationService.GetMedications());
        }


        [HttpGet("{medicationId}")]
        public IActionResult GetMedication(int medicationId)
        {
            return Ok(_medicationService.GetMedicationByID(medicationId));
        }


        [HttpPut]
        public IActionResult UpdateMedication([FromBody] MedicationViewModel medicationViewModel)
        {
            _medicationService.UpdateMedication(medicationViewModel);

            return  NoContent();
        }


    }
}