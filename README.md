# Envi.SDK

Envi.SDK contains a .NET SDK and runnable examples for Envi OData public API integration.

## Solution overview

The solution has two projects:

1. Api.Common.Entities
- DTO models used by SDK examples and API payload serialization/deserialization.

2. Envi.SDK
- OData client helper and response wrapper types.
- Runnable examples that demonstrate common integration scenarios.

Target framework for both projects is .NET 8.

## Project structure

Key folders and files:

- Envi.SDK/EnviODataClient.cs
	- Main SDK client wrapper for authenticated GET/POST/PUT/PATCH operations.
- Envi.SDK/SdkRuntimeConfiguration.cs
	- Reads and validates required runtime settings from appsettings.json.
- Envi.SDK/Examples/
	- InventoryExampleRunner.cs
	- BatchRequestExampleRunner.cs
	- InventoryMasterInterfaceRunner.cs
	- ODataQueryExamplesRunner.cs
	- DepletionInterfaceRunner.cs
- Envi.SDK/Program.cs
	- Console entry point that executes all example runners.
- Envi.SDK/PostmanCollection/Envi SDK Examples.postman_collection.json
	- Postman collection for manual API exploration.

## Implemented examples

Program execution demonstrates:

1. Inventory CRUD-like flow
- Create, read, update, and patch operations for Inventory.

2. Batch requests
- OData batch request composition and response processing.

3. Inventory Master interface flow
- Aggregation of Inventory, InventoryLocations, InventoryVendors, and VendorInfo data.

4. OData query options
- Top/skip, order-by, filter, search, and format examples.

5. Depletion interface
- Bulk create and submit usage data (Usages, UsageItems, UsageProcedures).

## Configuration

Update Envi.SDK/appsettings.json before running examples:

- baseAddress
- clientId
- userName
- password
- inventoryGroupId
- facilitiesNoList

## Prerequisites

- .NET SDK 8.0+

## Build

From repository root:

```bash
dotnet build Envi.SDK.sln
```

## Run examples

From repository root:

```bash
dotnet run --project Envi.SDK/Envi.SDK.csproj
```

The application runs all example flows sequentially.

## Notes

- The SDK uses OAuth2 Resource Owner Password flow for token retrieval in sample code.
- API route constants and OData response models are located in Envi.SDK for reuse across examples.
