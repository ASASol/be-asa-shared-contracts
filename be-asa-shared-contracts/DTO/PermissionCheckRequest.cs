namespace be_asa_shared_contracts.DTO
{
    public class PermissionCheckRequest
    {
        public Guid UserId { get; set; }
        public string FunctionCode { get; set; }
        public string CommandName { get; set; }
        public Guid BranchId { get; set; }
        public string? DepartmentCode { get; set; }
        public string? OutletCode { get; set; }
    }
}
