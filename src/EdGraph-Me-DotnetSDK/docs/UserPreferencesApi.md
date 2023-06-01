# EdGraph.Me.Client.Api.UserPreferencesApi

All URIs are relative to *https://api.edgraph.com/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UpdateUserPreference**](UserPreferencesApi.md#updateuserpreference) | **POST** /me/preferences | Update a user&#39;s preferences |

<a id="updateuserpreference"></a>
# **UpdateUserPreference**
> void UpdateUserPreference (string? apiVersion = null, string? xVersion = null, IdentityApiUserV1UpdateUserPreferenceRequest? identityApiUserV1UpdateUserPreferenceRequest = null)

Update a user's preferences

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Me.Client.Api;
using EdGraph.Me.Client.Client;
using EdGraph.Me.Client.Model;

namespace Example
{
    public class UpdateUserPreferenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserPreferencesApi(config);
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1UpdateUserPreferenceRequest = new IdentityApiUserV1UpdateUserPreferenceRequest?(); // IdentityApiUserV1UpdateUserPreferenceRequest? |  (optional) 

            try
            {
                // Update a user's preferences
                apiInstance.UpdateUserPreference(apiVersion, xVersion, identityApiUserV1UpdateUserPreferenceRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPreferencesApi.UpdateUserPreference: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserPreferenceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a user's preferences
    apiInstance.UpdateUserPreferenceWithHttpInfo(apiVersion, xVersion, identityApiUserV1UpdateUserPreferenceRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPreferencesApi.UpdateUserPreferenceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **identityApiUserV1UpdateUserPreferenceRequest** | [**IdentityApiUserV1UpdateUserPreferenceRequest?**](IdentityApiUserV1UpdateUserPreferenceRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | User preference updated |  -  |
| **400** | User preference has missing/invalid values |  -  |
| **500** | Oops! Can&#39;t update your user preference right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

