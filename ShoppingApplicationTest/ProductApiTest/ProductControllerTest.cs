using Moq;
using ProductApi.Controllers;
using ProductApi.model;
using ProductApi.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShoppingApplicationTest.ProductApiTest
{
    public class ProductControllerTest
    {
        private Mock<IProductRepository> productMockRepo;
        private ProductsController controller;

        public ProductControllerTest()
        {
            productMockRepo = new Mock<IProductRepository>();
            controller = new ProductsController(productMockRepo.Object);
        }

        [Fact]
        public void GetProductTest_RetursProductList()
        {
            // Arrange
            var mockProductList = new List<Product>
            {
                new Product { Id = 36}
                ///new Orders { Quantity = 5 }
            };
            productMockRepo.Setup(repo => repo.GetAll()).Returns(mockProductList);

            // Act
            var result =  controller.GetProducts();

            
            // Assert
            Assert.Equal(mockProductList, result);

        }

        [Fact]
        public void GetProductTest_ReturnsProduct_WhenProductExists()
        {
            // Arrange
            var mockId = 42;
            var mockProduct = new Product { Id = 42, Productname="hdvaj" };
            productMockRepo.Setup(repo => repo.GetOne(mockId)).Returns(mockProduct);

            // Act
            var result = controller.GetProducts(mockId);

            // Assert

            //Assert.IsType<ActionResult<Shipmentagent3>>(result);
            //var actionResult = Assert.IsType<OkObjectResult>(result);
            //Assert.IsType<OkObjectResult>(result);
            Assert.Equal(mockProduct, result);
        }

        [Fact]
        public void PostProductTest_ReturnsProductSuccessfullyAdded()
        {
            // Arrange
            var mockProduct = new Product { Id = 1, Productname = "hfbsd"};
            productMockRepo.Setup(repo => repo.SaveChanges());

            // Act
            var result = controller.PostProducts(mockProduct);

            // Assert
            productMockRepo.Verify(repo => repo.Add(mockProduct));
            //Assert.IsType<ActionResult<Orders>>(result);
            //var actionResult = Assert.IsType<OkObjectResult>(result);
            //Assert.Equal(mockOrder, result);
        }

        [Fact]
        public void DeleteProductTest_ReturnsSuccessCode_AfterRemovingProductFromRepository()
        {
            // Arrange
            var mockId = 42;
            var mockProduct = new Product { Id = 42,Productname = "sdgda" };
            productMockRepo.Setup(repo => repo.GetOne(mockId)).Returns(mockProduct);
            //orderMockRepo.Setup(repo => repo.Remove(mockOrder));
            productMockRepo.Setup(repo => repo.SaveChanges());

            // Act
            var result = controller.DeleteProducts(mockId);

            // Assert
            productMockRepo.Verify(repo => repo.Remove(mockProduct));
            //Assert.IsType<OkResult>(result);
        }
    }
}
