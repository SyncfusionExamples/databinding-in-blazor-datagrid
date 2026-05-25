# Blazor DataGrid Data Binding Samples

A comprehensive collection of samples demonstrating data binding capabilities in  Blazor DataGrid. Each sample showcases different data sources and binding patterns to help you integrate DataGrid into your Blazor applications.

## Overview

| Sample | Description |
|--------|-------------|
| `ListBinding` | Basic list data binding with SfGrid |
| `DataTable` | DataTable binding for dynamic data manipulation |
| `add_range_items_observableCollection` | Adding multiple items to an ObservableCollection |
| `observable_collection` | ObservableCollection data binding with real-time updates |
| `Binding_data_from_excel` | Importing and binding data from Excel files |
| `Render-image-in-dropdownlist` | Grid with foreign column and image rendering in dropdown |
| `Fetch-result_from_the_DataManager_query` | Web API adaptor with DataManager query support |
| `Offline-Mode` | DataGrid operations without network connectivity |
| `SignalRDataGrid` | Real-time data updates via SignalR hub |

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

- [Blazor DataGrid Documentation](https://www.syncfusion.com/blazor-components/blazor-datagrid)
- [ASP.NET Core Documentation](https://learn.microsoft.com/en-us/aspnet/core)
- [Blazor Documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor)
