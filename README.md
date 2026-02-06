# CopilotTest - Blazor Boilerplate Project

This is a boilerplate project demonstrating a modern .NET 10 Blazor Server application with SQLite database, Fluent UI components, and comprehensive testing.

## Features

- **Framework**: .NET 10 with Blazor Server
- **Database**: SQLite with Entity Framework Core
- **UI Components**: Microsoft Fluent UI Blazor
- **Testing**: xUnit with ASP.NET Core integration tests
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
│   └── CopilotTest.Tests/        # xUnit test project
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

4. Open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`

### Running Tests

Execute all tests:
```bash
dotnet test
```

Run tests with detailed output:
```bash
dotnet test --logger "console;verbosity=detailed"
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

## Development

### Adding New Pages

Create new Razor components in `src/CopilotTest.Web/Components/Pages/` directory.

### Adding Database Models

1. Create model classes in `src/CopilotTest.Web/Data/`
2. Add DbSet properties to `ApplicationDbContext`
3. Create and apply migrations (if needed)

### Writing Tests

Add new test classes to `tests/CopilotTest.Tests/` following the xUnit conventions.

## Contributing

This is a trial project for GitHub Copilot testing. Feel free to experiment and make changes.

## License

This project is for demonstration purposes.
