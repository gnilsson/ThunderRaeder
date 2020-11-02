using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ThunderRaeder.Client.Models.PostRequests;

namespace ThunderRaeder.Client.Util
{
    public static class ConvertionExtensions
    {
        public static string ToShortString(this string guidString)
        {
            var base64Guid = Convert.ToBase64String(new Guid(guidString).ToByteArray());
            base64Guid = base64Guid.Replace('+', '-').Replace('/', '_');
            return base64Guid[0..^2];
        }
        public static string FromShortString(this string str)
        {
            str = str.Replace('_', '/').Replace('-', '+');
            var byteArray = Convert.FromBase64String(str + "==");
            return new Guid(byteArray).ToString();
        }
        public static async Task<T> ToObjectAsync<T>(this byte[] jsonBytes)
        {
            return await Task.Run(() => JsonSerializer.Deserialize<T>(jsonBytes,
                     new JsonSerializerOptions
                     { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }));
        }
        public static T ToObject<T>(this byte[] jsonBytes)
        {
            return JsonSerializer.Deserialize<T>(jsonBytes,
                     new JsonSerializerOptions
                     { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }
        public static T ToObject<T>(this string jsonString)
        {
            return JsonSerializer.Deserialize<T>(jsonString,
                     new JsonSerializerOptions
                     { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }
        public static async Task<T> ToSingleObjectAsync<T>(this Task<string> jsonString)
        {
            var json = await jsonString;
            var correctJson = json.Remove(json.Length - 1).Remove(0, 8);
            return JsonSerializer.Deserialize<T>(correctJson,
                     new JsonSerializerOptions
                     { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }
        public static T ToSingleObject<T>(this string jsonString)
        {
            var correctJson = jsonString.Remove(jsonString.Length - 1).Remove(0, 8);
            return JsonSerializer.Deserialize<T>(correctJson,
                     new JsonSerializerOptions
                     { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }
    }
}
