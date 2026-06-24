# Blazor Gantt Chart with Entity framework

The [Blazor Gantt Chart](https://www.syncfusion.com/blazor-components/blazor-gantt-chart?utm_source=github&utm_medium=listing&utm_campaign=blazor-gantt-chart-github-samples) is a project planning and management tool that provides a Microsoft Project-like interface to display and manage hierarchical tasks with timeline details. 

This repository demonstrates how to integrate a Blazor Gantt Chart with a SQL database using the Entity Framework Data Model, enabling full CRUD operations through server-side communication.

## Project overview

In the Gantt Chart, we can fetch data from the SQL database using the Entity Framework Data Model and the update the changes in CRUD action to the server by using DataManager support. To communicate with the remote data, we are using CustomAdaptor of DataManager property to call the server method.

**Key Benefits of Entity Framework Core**

- Automatic SQL generation with optimized queries
- Strongly typed models for compile-time safety
- Parameterization to mitigate SQL injection
- Migrations to version database schema changes
- LINQ queries for expressive data access

## Prerequisites

Ensure the following software and packages are installed before proceeding:

| Software/Package | Version | Purpose |
|-----------------|---------|---------|
| Visual Studio 2022 | 18.2.1 or later | Development IDE with Blazor workload |
| .NET SDK | net8.0 or compatible | Runtime and build tools |
| SQL Server | 2021 or later | Database server |
| Syncfusion.Blazor.Gantt | -v {{site.blazorversion}} | Gantt Chart and UI components |
| Syncfusion.Blazor.Themes | -v {{site.blazorversion}} | Styling for Gantt Chart components |
| Microsoft.EntityFrameworkCore | 10.0.2 | Core framework for database operations |
| Microsoft.EntityFrameworkCore.SqlServer | 10.0.2 | SQL Server provider for Entity Framework Core |

## How to run the project

1. Clone or download this repository to your local system.
2. Open the project file (.csproj) in Visual Studio 2022 or later.
3. Rebuild the solution to restore NuGet packages.
4. Update the database connection string in the project's configuration (for example, `appsettings.json` or the DbContext configuration) to point to your SQL Server instance.
5. Ensure the database is available and migrations (if any) are applied.
6. Run the project and open the Gantt page. 
7. Test create, update and delete operations — changes are sent to the server via the CustomAdaptor and persisted by Entity Framework.

## Related links
[Learn More about Blazor Gantt Chart](https://www.syncfusion.com/blazor-components/blazor-gantt-chart?utm_source=github&utm_medium=listing&utm_campaign=blazor-gantt-chart-github-samples) <br/><br/>
[Download Free Trial](https://www.syncfusion.com/downloads?utm_source=github&utm_medium=listing&utm_campaign=blazor-gantt-chart-github-samples) <br/><br/>
[Pricing](https://www.syncfusion.com/sales/products/blazor?utm_source=github&utm_medium=listing&utm_campaign=blazor-gantt-chart-github-samples) <br/><br/>
[Documentation](https://blazor.syncfusion.com/documentation/gantt-chart/getting-started?utm_source=github&utm_medium=listing&utm_campaign=blazor-gantt-chart-github-samples) <br/><br/>
[Online Examples](https://blazor.syncfusion.com/demos/gantt-chart/default-functionalities?utm_source=github&utm_medium=listing&utm_campaign=blazor-gantt-chart-github-samples) <br/><br/>
[Watch a How-to Video](https://www.syncfusion.com/tutorial-videos/blazor/gantt-chart?title=create-a-gantt-chart-component-in-a-blazor-webassembly) <br/><br/>
[Community Forums](https://www.syncfusion.com/forums/blazor-components/gantt-chart?utm_source=github&utm_medium=listing&utm_campaign=blazor-gantt-chart-github-samples) <br/><br/>
[Suggest a feature](https://www.syncfusion.com/feedback/blazor-components?utm_source=github&utm_medium=listing&utm_campaign=blazor-gantt-chart-github-samples)
