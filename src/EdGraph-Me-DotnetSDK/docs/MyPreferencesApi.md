# EdGraph.Me.Client.Api.MyPreferencesApi

All URIs are relative to *https://api.edgraph.dev/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UpdateUserPreferenceAsync**](MyPreferencesApi.md#updateuserpreferenceasync) | **POST** /me/preferences | Creates or update a user&#39;s preference. |

<a id="updateuserpreferenceasync"></a>
# **UpdateUserPreferenceAsync**
> IdentityApiUserV1UserPreferenceUpdatedResponse UpdateUserPreferenceAsync (string? apiVersion = null, string? xVersion = null, EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsUpdateUserPreferenceRequest? edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsUpdateUserPreferenceRequest = null)

Creates or update a user's preference.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Me.Client.Api;
using EdGraph.Me.Client.Client;
using EdGraph.Me.Client.Model;

namespace Example
{
    public class UpdateUserPreferenceAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyPreferencesApi(config);
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsUpdateUserPreferenceRequest = new EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsUpdateUserPreferenceRequest?(); // EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsUpdateUserPreferenceRequest? |  (optional) 

            try
            {
                // Creates or update a user's preference.
                IdentityApiUserV1UserPreferenceUpdatedResponse result = apiInstance.UpdateUserPreferenceAsync(apiVersion, xVersion, edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsUpdateUserPreferenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MyPreferencesApi.UpdateUserPreferenceAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserPreferenceAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or update a user's preference.
    ApiResponse<IdentityApiUserV1UserPreferenceUpdatedResponse> response = apiInstance.UpdateUserPreferenceAsyncWithHttpInfo(apiVersion, xVersion, edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsUpdateUserPreferenceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MyPreferencesApi.UpdateUserPreferenceAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **edGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsUpdateUserPreferenceRequest** | [**EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsUpdateUserPreferenceRequest?**](EdGraphHttpAggregatorsTenantApiControllersV1ViewModelsRequestsUpdateUserPreferenceRequest?.md) |  | [optional]  |

### Return type

[**IdentityApiUserV1UserPreferenceUpdatedResponse**](IdentityApiUserV1UserPreferenceUpdatedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

