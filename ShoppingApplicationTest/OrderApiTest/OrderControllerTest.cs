using Microsoft.AspNetCore.Mvc;
using Moq;
using OrderApi.Controllers;
using OrderApi.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShoppingApplicationTest.OrderApiTest
{
    public class OrderControllerTest
    {
        private Mock<IOrderRepository> orderMockRepo;
        private OrdersController controller;

        public OrderControllerTest()
        {
            orderMockRepo = new Mock<IOrderRepository>();
            controller = new OrdersController(orderMockRepo.Object); 
        }

        [Fact]
        public async Task GetOrdersTest_RetursOrderList()
        {
            // Arrange
            var mockOrderList = new List<Orders>
            {
                new Orders { Id = 36}
                ///new Orders { Quantity = 5 }
            };
            orderMockRepo.Setup(repo => repo.GetAll()).Returns(Task.FromResult(mockOrderList));

            // Act
            var result = await controller.GetOrders();

            
            // Assert
            Assert.Equal(mockOrderList, result);

        }


        [Fact]
        public async Task GetOrderTest_ReturnsOrder_WhenOrderExists()
        {
            // Arrange
            var mockId = 42;
            var mockOrder = new Orders { Id = 42, Quantity = 3};
            orderMockRepo.Setup(repo => repo.GetOne(mockId)).Returns(Task.FromResult(mockOrder));

            // Act
            var result = await controller.GetOrders(mockId);

            // Assert
            //var actionResult = Assert.IsType<OkObjectResult>(result);
            //Assert.IsType<OkObjectResult>(result);
            Assert.Equal(mockOrder, result);
        }

        [Fact]
        public async Task PostOrderTest_ReturnsOrderSuccessfullyAdded()
        {
            // Arrange
            var mockOrder = new Orders { Id=1, Productid = 1, Quantity = 3};
            orderMockRepo.Setup(repo => repo.SaveChanges()).Returns(Task.CompletedTask);

            // Act
            var result = await controller.PostOrders(mockOrder);

            // Assert
            orderMockRepo.Verify(repo => repo.Add(mockOrder));
            //var actionResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(mockOrder, result);
        }

        [Fact]
        public async Task DeleteOrderTest_ReturnsSuccessCode_AfterRemovingOrderFromRepository()
        {
            // Arrange
            var mockId = 42;
            var mockOrder = new Orders { Id = 42, Quantity = 2 };
            //orderMockRepo.Setup(repo => repo.GetOne(mockId)).Returns(Task.FromResult(mockOrder));
            orderMockRepo.Setup(repo => repo.Remove(mockOrder));
            orderMockRepo.Setup(repo => repo.SaveChanges()).Returns(Task.CompletedTask);

            // Act
            var result = await controller.DeleteOrders(mockId);

            // Assert
            //orderMockRepo.Verify(repo => repo.Remove(mockOrder));
            Assert.IsType<OkResult>(result);
        }
    }
}
