namespace ThunderRaeder.Identity.API.Settings
{
    public class SwaggerSettings : SettingsBase<SwaggerSettings>
    {
        public string JsonRoute { get; set; }

        public string Description { get; set; }

        public string UIEndpoint { get; set; }
    }
}
