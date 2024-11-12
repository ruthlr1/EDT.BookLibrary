using EDT.BookLibrary.API;
using Microsoft.AspNetCore.Mvc.Testing;
using System;

namespace EDT.BookLibrary.Tests.Common
{
    [TestClass]
    public class HealthCheckTests
    {

        [TestMethod]
        public async Task Api_IsRunning_ReturnsSuccessfulResponse()
        {
            // Arrange
            var factory = new WebApplicationFactory<Registry>();
            var client = factory.CreateClient();
            string apiUrl = "/Health";

            // Act
            var response = await client.GetAsync(apiUrl);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299

            // Assert
            Assert.IsTrue(response.IsSuccessStatusCode, $"API did not return a success status. Status code: {response.StatusCode}");
        }
    }
}
