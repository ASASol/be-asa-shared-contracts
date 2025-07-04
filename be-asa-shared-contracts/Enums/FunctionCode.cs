namespace be_asa_shared_contracts.Enums
{
    public enum FunctionCode // thêm chức năng phía dưới cùng k làm đôi thứ tự
    {
        // Super admin

        ROLE_MANAGEMENT,
        FUNCTION_MANAGEMENT,
        COMMAND_MANAGEMENT,
        COMMANDINFUNCTION_MANAGEMENT,
        SUBSYSTEM_MANAGEMENT,
        PERMISSIONGROUPTYPE_MANAGEMENT,
        BRANCH_MANAGEMENT,
        USER_SETTING_MANAGEMENT,

        // Admin 
        PERMISSION_MANAGEMENT,
        PERMISSIONGROUP_MANAGEMENT,
        USERINBRANCH_MANAGEMENT,
        LOGGING_MANAGEMENT,

        // User

        //Menu
        AUTHENTICATION_MANAGEMENT,
        FOODORDER_MANAGEMENT,
        HOTEL_MANAGEMENT,
        SETTING_MANAGEMENT,
    }
}
