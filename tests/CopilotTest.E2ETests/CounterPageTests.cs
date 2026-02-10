using Microsoft.Playwright.NUnit;

namespace CopilotTest.E2ETests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class CounterPageTests : PageTest
{
    [Test]
    public async Task CounterPage_ShouldIncrementCount_WhenButtonClicked()
    {
        // Arrange - Navigate to the Counter page
        await Page.GotoAsync("http://localhost:5258/counter");
        
        // Wait for the page to load
        await Page.WaitForLoadStateAsync(Microsoft.Playwright.LoadState.NetworkIdle);
        
        // Assert - Initial count is 0
        var currentCountElement = Page.Locator("p[role='status']");
        await Expect(currentCountElement).ToHaveTextAsync("Current count: 0");
        
        // Act - Click the button
        var incrementButton = Page.Locator("button.btn.btn-primary");
        await incrementButton.ClickAsync();
        
        // Assert - Count should be incremented to 1
        await Expect(currentCountElement).ToHaveTextAsync("Current count: 1");
        
        // Act - Click the button again
        await incrementButton.ClickAsync();
        
        // Assert - Count should be incremented to 2
        await Expect(currentCountElement).ToHaveTextAsync("Current count: 2");
    }
}
