using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using Xunit;

namespace CopilotTest.Tests;

public class HealthCheckTests : IClassFixture<CustomWebApplicationFactory>
{
    private readonly CustomWebApplicationFactory _factory;

    public HealthCheckTests(CustomWebApplicationFactory factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task HealthCheck_EndpointExists()
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync("/health");

        // Assert
        Assert.NotEqual(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task HealthCheck_ReturnsResponse()
    {
        // Arrange  
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync("/health");

        // Assert - the health check endpoint should respond (even if unhealthy in test environment)
        Assert.True(response.StatusCode == HttpStatusCode.OK || 
                    response.StatusCode == HttpStatusCode.ServiceUnavailable,
            $"Health check should return OK or ServiceUnavailable, but got {response.StatusCode}");
    }
}
