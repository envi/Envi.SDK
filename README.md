# IOSCorp.SDK
This repository is intended to contain source code of SDK and examples of usage for Envi OData public API

Solution consists of two projects:

1. Api.Common.Entities - contains DTO classes (models) and enums that are used by API and will be used by SDK in the nearest future;
2. IOSCorp.SDK - contains generic helper classes, which represents different kinds of OData request/response messages. Class Program contains the next examples of API invocation:
	- Example on obtaining of JWT token, usage of access token for auth and refresh token for JWT renewal;
	- Simple GET, POST, PUT, PUTCH calls based on Inventory module. In general, principles are the same for all implemented modules;
	- Example of Inventory Master Interface data retrieving using API;
	- Example of Batch Request usage (when multiple request are send in a batch).
