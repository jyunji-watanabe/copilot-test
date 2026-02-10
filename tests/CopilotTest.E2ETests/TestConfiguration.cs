namespace CopilotTest.E2ETests;

public static class TestConfiguration
{
    public static string BaseUrl => Environment.GetEnvironmentVariable("E2E_BASE_URL") ?? "http://localhost:5258";
}
