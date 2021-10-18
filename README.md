# Envi.SDK
This repository contains a source code of SDK and examples of how to use Envi OData public API. It consists of two projects:

Solution consists of two projects:

1. Api.Common.Entities - contains DTO classes (models) and enums that will be used by API and SDK in the nearest future;
2. Envi.SDK - contains generic helper classes which represent different kinds of OData request or response messages. The Program сlass contains the following examples of API invocation:
	- Obtaining the JWT token, using access token for auth 2.0 resource owner credentials flow, and refreshing the JWT token when it expires;
	- Using simple GET, POST, PUT, and PATCH calls based on Inventory module. Generally, all implemented modules use the same pattern;
	- Retrieving Inventory Master Interface data using API;
	- Using Batch Request (in case multiple requests are sent in a batch).
