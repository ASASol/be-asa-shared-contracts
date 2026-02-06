using be_asa_shared_contracts.DTO;

namespace be_asa_shared_contracts.Interfaces
{
    public interface IPermissionClient
    {
        Task<bool> CheckPermissionAsync(PermissionCheckRequest request, string bearerToken);
        Task<ApiResponse<PermissionCheckResult>> CheckPermissionClientAsync(PermissionCheckRequest request, string bearerToken);
        Task<ApiResponse<PermissionCheckResult>> CheckBasePermissionAsync(string bearerToken);
    }
}
