using Microsoft.AspNetCore.Mvc;
using Moq;
using PaymentApi.Controllers;
using PaymentApi.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShoppingApplicationTest.PaymentApiTest
{
    public class PaymentControllerTest
    {
        private Mock<IPaymentRepository> paymentMockRepo;
        private PaymentsController controller;

        public PaymentControllerTest()
        {
            paymentMockRepo = new Mock<IPaymentRepository>();
            controller = new PaymentsController(paymentMockRepo.Object);
        }

        [Fact]
        public async Task GetPaymentsTest_ReturnsPaymentList()
        {
            // Arrange
            var mockPaymentList = new List<Payment>
            {
                new Payment { Id = 36}
                
            };
            paymentMockRepo.Setup(repo => repo.GetAll()).Returns(Task.FromResult(mockPaymentList));

            // Act
            var result = await controller.GetPayment();


            // Assert
            Assert.Equal(mockPaymentList, result);

        }

        [Fact]
        public async Task GetPaymentTest_ReturnsPayment_WhenPaymentExists()
        {
            // Arrange
            var mockId = 42;
            var mockPayment = new Payment {  Id = 42, Creditnumber = "8765" };
            paymentMockRepo.Setup(repo => repo.GetOne(mockId)).Returns(Task.FromResult(mockPayment));

            // Act
            var result = await controller.GetPayment(mockId);

            // Assert
            //var actionResult = Assert.IsType<OkObjectResult>(result);
            //Assert.IsType<OkObjectResult>(result);
            Assert.Equal(mockPayment, result);
        }

        [Fact]
        public async Task PostPaymentTest_ReturnsPaymentSuccessfullyAdded()
        {
            // Arrange
            var mockPayment = new Payment { Id = 1};
            paymentMockRepo.Setup(repo => repo.SaveChanges()).Returns(Task.CompletedTask);

            // Act
            var result = await controller.PostPayment(mockPayment);

            // Assert
            paymentMockRepo.Verify(repo => repo.Add(mockPayment));
            //var actionResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(mockPayment, result);
        }

        [Fact]
        public async Task DeletePaymentTest_ReturnsSuccessCode_AfterRemovingPaymentFromRepository()
        {
            // Arrange
            var mockId = 42;
            var mockPayment = new Payment { Id = 42, Creditnumber = "34464" };
            paymentMockRepo.Setup(repo => repo.GetOne(mockId)).Returns(Task.FromResult(mockPayment));
            //paymentMockRepo.Setup(repo => repo.Remove(mockPayment));
            paymentMockRepo.Setup(repo => repo.SaveChanges()).Returns(Task.CompletedTask);

            // Act
            var result = await controller.DeletePayment(mockId);

            // Assert
            paymentMockRepo.Verify(repo => repo.Remove(mockPayment));
            Assert.IsType<OkResult>(result);
        }
    }
}
