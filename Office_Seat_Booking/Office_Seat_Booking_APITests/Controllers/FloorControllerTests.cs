﻿using AutoFixture;
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
    public class FloorControllerTests
    {
        FloorController floorController;
        Fixture _fixture;
        Mock<IFloorRepost> moq;
        public FloorControllerTests()
        {
            _fixture = new Fixture();
            moq = new Mock<IFloorRepost>();
        }

        [TestMethod()]
        public async Task GetFloorsTest()
        {
            var floorlist = _fixture.CreateMany<Floor>(3).ToList();
            moq.Setup(x => x.GetFloors()).Returns(floorlist);
            floorController = new FloorController(new FloorService(moq.Object));
            var result = floorController.GetFloors();
            Assert.AreEqual(result.Count(), 3);
        }
        [TestMethod()]
        public async Task GetFloorsNegativeTest()
        {
            List<Floor> floorlist = null;
            moq.Setup(x => x.GetFloors()).Returns(floorlist);
            floorController = new FloorController(new FloorService(moq.Object));
            Assert.IsNull(floorController.GetFloors());
        }
        [TestMethod()]
        public void DeleteFloorTest()
        {
            var floor = _fixture.Create<Floor>();
            moq.Setup(x => x.DeleteFloor(1));
            floorController = new FloorController(new FloorService(moq.Object));
            var result = floorController.DeleteFloor(1);
            var Obj = result as ObjectResult;
            Assert.AreEqual(Obj.StatusCode, 200);
        }
    
        [TestMethod()]
        public void UpdateFloorTest()
        {
            var floor = _fixture.Create<Floor>();
            moq.Setup(x => x.UpdateFloor(floor));
            floorController = new FloorController(new FloorService(moq.Object));
            var result = floorController.UpdateFloor(floor);
            var Obj = result as ObjectResult;
            Assert.AreEqual(200, Obj.StatusCode);
        }
     
        [TestMethod()]
        public void GetFloorByIdTest()
        {
            var floor = _fixture.Create<Floor>();
            moq.Setup(x => x.GetFloorById(1)).Returns(floor);
            floorController = new FloorController(new FloorService(moq.Object));
            Assert.AreEqual(floorController.GetFloorById(1), floor);
        }
        [TestMethod()]
        public void GetFloorById_ExistingIdPassed_ReturnsRightItem()
        {
            // Arrange
            var floor = _fixture.Create<Floor>();
            moq.Setup(x => x.GetFloorById(10)).Returns(floor);
            floorController = new FloorController(new FloorService(moq.Object));
            // Act
            var okResult = floorController.GetFloorById(1);
            // Assert
            Assert.AreEqual(okResult, null);
        }
        [TestMethod()]
        public async Task AddFloorTest()
        {
            var floor = _fixture.Create<Floor>();
            moq.Setup(x => x.AddFloor(floor));
            floorController = new FloorController(new FloorService(moq.Object));
            var result = floorController.AddFloor(floor);
            var Obj = result as ObjectResult;
            Assert.AreEqual(200, Obj.StatusCode);
        }
        
    }
}
