using Microsoft.AspNetCore.Mvc;
using Moq;
using ShipmentApi.Controllers;
using ShipmentApi.model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShoppingApplicationTest.ShipmentApiTest
{
    public class ShipmentControllerTest
    {
        private Mock<IShipmentRepository> shipmentMockRepo;
        private Shipmentagent3Controller controller;

        public ShipmentControllerTest()
        {
            shipmentMockRepo = new Mock<IShipmentRepository>();
            controller = new Shipmentagent3Controller(shipmentMockRepo.Object);
        }

        [Fact]
        public async Task GetShipmentTest_RetursShipmentList()
        {
            // Arrange
            var mockShipmentList = new List<Shipmentagent3>
            {
                new Shipmentagent3 { Id = 36}
                ///new Orders { Quantity = 5 }
            };
            shipmentMockRepo.Setup(repo => repo.GetAll()).Returns(Task.FromResult(mockShipmentList));

            // Act
            var result = await controller.GetShipmentagent3();

            Assert.IsType<ActionResult<IEnumerable<Shipmentagent3>>>(result);
            // Assert
            //Assert.Equal(mockOrderList, result);

        }


        [Fact]
        public async Task GetShipmentTest_ReturnsShipment_WhenShipmentExists()
        {
            // Arrange
            var mockId = 42;
            var mockShipment = new Shipmentagent3 { Id = 42, DeliveryGuy = "fdvdgfh" };
            shipmentMockRepo.Setup(repo => repo.GetOne(mockId)).Returns(Task.FromResult(mockShipment));

            // Act
            var result = await controller.GetShipmentagent3(mockId);

            // Assert

            Assert.IsType<ActionResult<Shipmentagent3>>(result);
            //var actionResult = Assert.IsType<OkObjectResult>(result);
            //Assert.IsType<OkObjectResult>(result);
            //Assert.Equal(mockOrder, result);
        }

        [Fact]
        public async Task PostShipmentTest_ReturnsShipmentSuccessfullyAdded()
        {
            // Arrange
            var mockShipment = new Shipmentagent3 { Id = 1, DeliveryGuy = "sfvgsdg"};
            shipmentMockRepo.Setup(repo => repo.SaveChanges()).Returns(Task.CompletedTask);

            // Act
            var result = await controller.PostShipmentagent3(mockShipment);

            // Assert
            shipmentMockRepo.Verify(repo => repo.Add(mockShipment));
            //Assert.IsType<ActionResult<Orders>>(result);
            //var actionResult = Assert.IsType<OkObjectResult>(result);
            //Assert.Equal(mockOrder, result);
        }

        [Fact]
        public async Task DeleteOrderTest_ReturnsSuccessCode_AfterRemovingOrderFromRepository()
        {
            // Arrange
            var mockId = 42;
            var mockShipment = new Shipmentagent3 { Id = 42, DeliveryGuy = "fhfdbf"};
            shipmentMockRepo.Setup(repo => repo.GetOne(mockId)).Returns(Task.FromResult(mockShipment));
            //orderMockRepo.Setup(repo => repo.Remove(mockOrder));
            shipmentMockRepo.Setup(repo => repo.SaveChanges()).Returns(Task.CompletedTask);

            // Act
            var result = await controller.DeleteShipmentagent3(mockId);

            // Assert
            shipmentMockRepo.Verify(repo => repo.Remove(mockShipment));
            //Assert.IsType<OkResult>(result);
        }
    }
}
