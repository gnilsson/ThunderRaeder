namespace ThunderRaeder.API.Security.Settings
{
    public class JwtSettings : SettingsBase<JwtSettings>
    {
        public string Secret { get; set; }
    }
}
