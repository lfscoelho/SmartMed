using AutoMapper;
using Moq;
using SmartMed.API.Controllers;
using SmartMed.Application.Interfaces;
using SmartMed.Application.Services;
using SmartMed.Application.ViewModels;
using SmartMed.Domain.Interfaces;
using System;
using Xunit;

namespace SmartMed.Tests
{
    public class MedicationTests
    {
        private MedicationService _medicationService;

        public MedicationTests()
        {
            var ratesServiceMock = new Mock<IMedicationService>();

            //ratesServiceMock.Setup(x => x.InsertMedication()).Returns("");


            //ratesServiceMock.Setup(x => x.GetRate(It.IsAny<int>())).Returns((ExchangeRates er) => er);


            var mockRepo = new Mock<IMedicationRepository>();
            var mockAutoMapper = new Mock<IMapper>();

            _medicationService = new MedicationService(mockRepo.Object, mockAutoMapper.Object);
        }

        [Fact]
        public void ShouldFailIfQuantityIsLessThanOne()
        {
            //Arrange
            MedicationViewModel medicationViewModel = new MedicationViewModel()
            {
                CreationDate = DateTime.Now,
                Quantity = 0
            };


            MedicationController controller = new MedicationController(_medicationService);

            var result = controller.Post(medicationViewModel);


            //Act

            //Assert
        }
    }
}
