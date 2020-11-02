using System;

namespace ThunderRaeder.Identity.API.Settings
{
    public class JwtSettings : SettingsBase<JwtSettings>
    {
        public string Secret { get; set; }
        public TimeSpan TokenLifetime { get; set; }
    }
}
