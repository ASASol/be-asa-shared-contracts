using be_asa_shared_contracts.DTO;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;

namespace be_asa_shared_contracts.Interfaces
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

        public async Task<bool> CheckPermissionAsync(PermissionCheckRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/api/v1/system/permissions/check", request);

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogWarning("Permission check failed: {Status}", response.StatusCode);
                    return false;
                }

                var result = await response.Content.ReadFromJsonAsync<bool>();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error calling permission check");
                return false;
            }
        }
    }
}
