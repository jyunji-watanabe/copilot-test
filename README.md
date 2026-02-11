# CopilotTest - Blazor Boilerplate Project

This is a boilerplate project demonstrating a modern .NET 10 Blazor Server application with SQLite database, Fluent UI components, and comprehensive testing.

## Features

- **Framework**: .NET 10 with Blazor Server
- **Database**: SQLite with Entity Framework Core
- **UI Components**: Microsoft Fluent UI Blazor
- **Testing**: xUnit with ASP.NET Core integration tests
- **E2E Testing**: Playwright for end-to-end browser testing
- **Health Checks**: Built-in health check endpoint for monitoring

## Project Structure

```
CopilotTest/
├── src/
│   └── CopilotTest.Web/          # Main Blazor application
│       ├── Components/            # Blazor components and pages
│       ├── Data/                  # Database context and models
│       └── Program.cs             # Application entry point
├── tests/
│   ├── CopilotTest.Tests/        # xUnit test project
│   └── CopilotTest.E2ETests/     # Playwright E2E test project
└── CopilotTest.sln               # Solution file
```

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### Running the Application

1. Clone the repository:
   ```bash
   git clone https://github.com/jyunji-watanabe/copilot-test.git
   cd copilot-test
   ```

2. Build the solution:
   ```bash
   dotnet build
   ```

3. Run the web application:
   ```bash
   dotnet run --project src/CopilotTest.Web
   ```

4. Open your browser and navigate to `https://localhost:7084` or `http://localhost:5258`

### Running Tests

Execute all tests (unit and integration tests):
```bash
dotnet test
```

Run tests with detailed output:
```bash
dotnet test --logger "console;verbosity=detailed"
```

### Running E2E Tests

E2E tests use Playwright to test the application in a real browser.

**Note**: Playwright browsers are automatically installed when you build the E2E test project for the first time. No manual installation is required.

#### Running the E2E Tests

1. Start the web application in one terminal:
   ```bash
   dotnet run --project src/CopilotTest.Web
   ```

2. In another terminal, run the E2E tests:
   ```bash
   dotnet test tests/CopilotTest.E2ETests
   ```

Alternatively, run all tests including E2E tests from the root directory:
```bash
dotnet test
```

**Note**: The E2E tests expect the application to be running on `http://localhost:5258`. Make sure the application is started before running the tests. You can override the base URL by setting the `E2E_BASE_URL` environment variable:

```bash
export E2E_BASE_URL=http://localhost:5000
dotnet test tests/CopilotTest.E2ETests
```

## Health Check

The application includes a health check endpoint that verifies the database connection and overall application health.

- **Endpoint**: `/health`
- **Method**: GET
- **Response**: `Healthy` (HTTP 200) when all checks pass

Example:
```bash
curl http://localhost:5000/health
```

## Database

The application uses SQLite as the database provider. The database file (`app.db`) is automatically created when the application starts for the first time.

### Sample Data

The database is seeded with sample entities to demonstrate basic CRUD operations and data display using Fluent UI components.

## Technology Stack

- **ASP.NET Core 10.0**: Modern web framework
- **Blazor Server**: Server-side rendering with real-time updates
- **Entity Framework Core 10.0**: ORM for database operations
- **SQLite**: Lightweight, file-based database
- **Microsoft Fluent UI Blazor**: Modern UI component library
- **xUnit**: Unit testing framework
- **Microsoft.AspNetCore.Mvc.Testing**: Integration testing support
- **Playwright**: Browser automation for E2E testing

## Development

### Adding New Pages

Create new Razor components in `src/CopilotTest.Web/Components/Pages/` directory.

### Adding Database Models

1. Create model classes in `src/CopilotTest.Web/Data/`
2. Add DbSet properties to `ApplicationDbContext`
3. Create and apply migrations (if needed)

### Writing Tests

Add new test classes to `tests/CopilotTest.Tests/` following the xUnit conventions.

### Writing E2E Tests

Add new E2E test classes to `tests/CopilotTest.E2ETests/` using Playwright. E2E tests should:
- Inherit from `PageTest` for page-level tests
- Use Playwright locators to interact with UI elements
- Follow the Arrange-Act-Assert pattern
- Test user workflows through the browser

## Contributing

This is a trial project for GitHub Copilot testing. Feel free to experiment and make changes.

## License

This project is for demonstration purposes.
