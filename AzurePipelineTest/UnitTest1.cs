using AzurePipeline.Controllers;
using AzurePipeline;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Moq;

namespace AzurePipelineTest
{
    [TestClass]
    public class WeatherForecastControllerTests
    {
        [TestMethod]
        public void Get_ReturnsCorrectNumberOfForecasts()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(loggerMock.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            var forecasts = result as IEnumerable<WeatherForecast>;
            Assert.IsNotNull(forecasts);
            Assert.AreEqual(5, forecasts.Count());
        }
    }
}