# Blazor DataGrid Data Binding Samples

A comprehensive collection of production-ready samples demonstrating modern data binding techniques in [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid).


## Overview

This project demonstrate essential data binding patterns for the Blazor DataGrid component. Whether you're building applications with static lists, real-time updates via SignalR, offline-first capabilities, or complex server-side operations, you'll find a working example here.

Each sample is a complete, standalone project with best practices for:
- Clean architecture and separation of concerns
- CRUD operations (Create, Read, Update, Delete)
- Advanced filtering, sorting, and paging
- Error handling and user experience considerations


## Features

### Data Binding

- **Local Data Sources**: Bind to List<T>, ObservableCollection, DataTable
- **Remote Data**: Web API adaptor with server-side paging, sorting, and filtering
- **Excel Integration**: Import data directly from Excel workbooks

### DataGrid Operations

- **CRUD Operations**: Add, edit, delete records inline or via toolbar
- **Editing Modes**: Dialog, Inline, and batch editing support
- **Foreign Key Columns**: Dropdown rendering with custom templates

### Real-Time Updates

- **SignalR Integration**: Live data updates without page refresh
- **Observable Collections**: Automatic UI updates on data changes

### Offline Mode

- **Local Data Storage**: Persist changes locally when server is unavailable
- **Sync When Online**: Automatically sync data when connectivity is restored

## Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
- [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the repository

```bash
git clone https://github.com/SyncfusionExamples/databinding-in-blazor-datagrid.git
cd databinding-in-blazor-datagrid
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run
```
## References

- [Blazor DataGrid Documentation](https://blazor.syncfusion.com/documentation/datagrid/getting-started-with-web-app)
-  [Blazor DataBinding Documentation](https://blazor.syncfusion.com/documentation/datagrid/data-binding/data-binding)
- [Online DataBinding Demo](https://blazor.syncfusion.com/demos/datagrid/local-data?theme=fluent2)

