namespace ThunderRaeder.API.Security.Settings
{
    public class MsGraphSettings : SettingsBase<MsGraphSettings>
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string TenantId { get; set; }
        public string RedirectUri { get; set; }
        public string Scopes { get; set; }
    }
}
