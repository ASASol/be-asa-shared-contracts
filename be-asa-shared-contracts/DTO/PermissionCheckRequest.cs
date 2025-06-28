using be_asa_shared_contracts.Enums;

namespace be_asa_shared_contracts.DTO
{
    public class PermissionCheckRequest
    {
        public Guid UserId { get; set; }
        public FunctionCode FunctionCode { get; set; }
        public CommandName CommandName { get; set; }
        public Guid BranchId { get; set; }
    }
}
