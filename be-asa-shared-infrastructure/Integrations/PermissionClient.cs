using be_asa_shared_contracts.DTO;
using be_asa_shared_contracts.Interfaces;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace be_asa_shared_infrastructure.Integrations
{
    public class PermissionClient : IPermissionClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<PermissionClient> _logger;

        public PermissionClient(HttpClient httpClient, ILogger<PermissionClient> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<bool> CheckPermissionAsync(PermissionCheckRequest request, string bearerToken)
        {
            try
            {
                var httpRequest = new HttpRequestMessage(HttpMethod.Post, "/api/v1/system/permissions/check")
                {
                    Content = JsonContent.Create(request)
                };

                if (!string.IsNullOrWhiteSpace(bearerToken))
                {
                    httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken.Replace("Bearer ", ""));
                }

                var response = await _httpClient.SendAsync(httpRequest);

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogWarning("Permission check failed: {Status}", response.StatusCode);
                    return false;
                }

                var result = await response.Content.ReadFromJsonAsync<ApiResponse<PermissionCheckResult>>();

                if (result?.Data == null)
                {
                    _logger.LogWarning("Permission check result does not contain data.");
                    return false;
                }

                return result.Data.HasPermission;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error calling permission check");
                return false;
            }
        }
        public void SetBearerToken(string bearerToken)
        {
            if (!string.IsNullOrWhiteSpace(bearerToken))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", bearerToken.Replace("Bearer ", ""));
            }
        }
    }

}
