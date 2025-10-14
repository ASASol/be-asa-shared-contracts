namespace be_asa_shared_contracts.Utils
{
    public class ThemeBase : BaseEntity
    {
        public string Name { get; set; }
        public string JsonConfig { get; set; }
        public int? Version { get; set; }
        public bool IsDefault { get; set; }
    }
}
