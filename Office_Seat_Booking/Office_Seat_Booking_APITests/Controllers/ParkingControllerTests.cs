using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Office_Seat_booking_API.Controllers;
using Office_Seat_Booking_BLL.Services;
using Office_Seat_Booking_DLL.Repost;
using Office_Seat_Booking_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_APITests.Controllers.Tests
{
    [TestClass()]
    public class ParkingControllerTests
    {
        ParkingController parkingController;
        Fixture _fixture;
        Mock<IParkingRepost> moq;
        public ParkingControllerTests()
        {
            _fixture = new Fixture();
            moq = new Mock<IParkingRepost>();
        }

        [TestMethod()]
        public async Task GetParkingsTest()
        {
            var parkinglist = _fixture.CreateMany<Parking>(3).ToList();
            moq.Setup(x => x.GetParkings()).Returns(parkinglist);
            parkingController = new ParkingController(new ParkingService(moq.Object));
            var result = parkingController.GetParkings();
            Assert.AreEqual(result.Count(), 3);
        }
        [TestMethod()]
        public async Task GetParkingsNegativeTest()
        {
            List<Parking> parkinglist = null;
            moq.Setup(x => x.GetParkings()).Returns(parkinglist);
            parkingController = new ParkingController(new ParkingService(moq.Object));
            Assert.IsNull(parkingController.GetParkings());
        }
        [TestMethod()]
        public void DeleteParkingTest()
        {
            var parking = _fixture.Create<Parking>();
            moq.Setup(x => x.DeleteParking(1));
            parkingController = new ParkingController(new ParkingService(moq.Object));
            var result = parkingController.DeleteParking(1);
            var Obj = result as ObjectResult;
            Assert.AreEqual(Obj.StatusCode, 200);
        }

        [TestMethod()]
        public void UpdateParkingTest()
        {
            var parking = _fixture.Create<Parking>();
            moq.Setup(x => x.UpdateParking(parking));
            parkingController = new ParkingController(new ParkingService(moq.Object));
            var result = parkingController.UpdateParking(parking);
            var Obj = result as ObjectResult;
            Assert.AreEqual(200, Obj.StatusCode);
        }

        [TestMethod()]
        public void GetParkingByIdTest()
        {
            var parking = _fixture.Create<Parking>();
            moq.Setup(x => x.GetParkingById(1)).Returns(parking);
            parkingController = new ParkingController(new ParkingService(moq.Object));
            Assert.AreEqual(parkingController.GetParkingById(1), parking);
        }
        [TestMethod()]
        public void GetParkingById_ExistingIdPassed_ReturnsRightItem()
        {
            // Arrange
            var parking = _fixture.Create<Parking>();
            moq.Setup(x => x.GetParkingById(10)).Returns(parking);
            parkingController = new ParkingController(new ParkingService(moq.Object));
            // Act
            var okResult = parkingController.GetParkingById(1);
            // Assert
            Assert.AreEqual(okResult, null);
        }
        [TestMethod()]
        public async Task AddParkingTest()
        {
            var parking = _fixture.Create<Parking>();
            moq.Setup(x => x.AddParking(parking));
            parkingController = new ParkingController(new ParkingService(moq.Object));
            var result = parkingController.AddParking(parking);
            var Obj = result as ObjectResult;
            Assert.AreEqual(200, Obj.StatusCode);
        }

    }
}
