using System;

namespace ThunderRaeder.Utility.DataType
{
    public static class Extensions
    {
        public static Guid GuidTryParseExact(this string requestGuid)
        {
            return Guid.TryParseExact(requestGuid, "D", out var result) ? result : Guid.Empty;
        }
    }
}
