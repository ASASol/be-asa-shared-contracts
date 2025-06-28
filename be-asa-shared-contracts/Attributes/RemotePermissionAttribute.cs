using be_asa_shared_contracts.Enums;

namespace be_asa_shared_contracts.Attributes
{
    public class RemotePermissionAttribute : Attribute
    {
        public FunctionCode FunctionCode { get; }
        public CommandName CommandName { get; }

        public RemotePermissionAttribute(FunctionCode functionCode, CommandName commandName)
        {
            FunctionCode = functionCode;
            CommandName = commandName;
        }
    }
}
