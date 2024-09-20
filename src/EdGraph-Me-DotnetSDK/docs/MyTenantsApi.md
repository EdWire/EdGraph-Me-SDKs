# EdGraph.Me.Client.Api.MyTenantsApi

All URIs are relative to *https://api.int.txedexchange.net/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetUserTenants**](MyTenantsApi.md#getusertenants) | **GET** /me/tenants | Retrieves the Tenants of the User that is currently logged in. |

<a id="getusertenants"></a>
# **GetUserTenants**
> IdentityApiUserV1UserTenantProfilePaginatedItemsViewModel GetUserTenants (int? pageIndex = null, int? pageSize = null, string? filter = null, string? orderBy = null, string? apiVersion = null, string? xVersion = null)

Retrieves the Tenants of the User that is currently logged in.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Me.Client.Api;
using EdGraph.Me.Client.Client;
using EdGraph.Me.Client.Model;

namespace Example
{
    public class GetUserTenantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.int.txedexchange.net/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyTenantsApi(config);
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves the Tenants of the User that is currently logged in.
                IdentityApiUserV1UserTenantProfilePaginatedItemsViewModel result = apiInstance.GetUserTenants(pageIndex, pageSize, filter, orderBy, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyTenantsApi.GetUserTenants: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserTenantsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the Tenants of the User that is currently logged in.
    ApiResponse<IdentityApiUserV1UserTenantProfilePaginatedItemsViewModel> response = apiInstance.GetUserTenantsWithHttpInfo(pageIndex, pageSize, filter, orderBy, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MyTenantsApi.GetUserTenantsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |
| **orderBy** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**IdentityApiUserV1UserTenantProfilePaginatedItemsViewModel**](IdentityApiUserV1UserTenantProfilePaginatedItemsViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **404** | The resource could not be found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

