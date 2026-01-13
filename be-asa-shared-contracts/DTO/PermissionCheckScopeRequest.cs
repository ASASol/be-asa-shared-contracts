namespace be_asa_shared_contracts.DTO
{
    public class PermissionCheckScopeRequest : PermissionCheckRequest
    {
        public string? DepartmentCode { get; set; }
        public string? OutletCode { get; set; }
    }
}
