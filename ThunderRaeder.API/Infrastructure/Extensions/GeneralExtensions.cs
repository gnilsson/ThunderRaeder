using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.Infrastructure.Extensions
{
    public static class GeneralExtensions
    {
        public static string ToUserPrincipalName(this string email, int? attempt = null)
        {
            var attemptValue = attempt == null ? string.Empty : attempt.ToString();
            return $"{email.Split('@')[0]}{attemptValue}@nackadomain.onmicrosoft.com";
        }

        public static async Task<string> ReadToStringAsync(this IFormFile file)
        {
            var builder = new StringBuilder();
            using var reader = new StreamReader(file.OpenReadStream());
            while (reader.Peek() >= 0)
                builder.AppendLine(await reader.ReadLineAsync());
            return builder.ToString();
        }

        public static async Task Create(this IFormFile file)
        {
            var fileName = ContentDispositionHeaderValue.Parse(
                   file.ContentDisposition).FileName.Trim('"');
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, @"Uploads\" + fileName);
            using var fs = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fs);
        }

        public static bool? IsEmptyObject(this object obj)
        {
            return obj switch
            {
                DateTime dt => dt.Ticks == 0,
                ICollection<object> col => col.Count == 0,
                string s => string.IsNullOrWhiteSpace(s),
                //   Enum e => e.CompareTo(0) == 0,
                _ => false
            };
        }

        public static Dictionary<TKey, TValue> AddRange<TKey, TValue>(
            this Dictionary<TKey, TValue> current,
            IDictionary<TKey, TValue> target)
            where TKey : notnull
        {
            foreach (var value in target)
            {
                current.Add(value.Key, value.Value);
            }
            return current;
        }

        public static Dictionary<TKey, TValue> AddRange<TKey, TValue>(
            this Dictionary<TKey, TValue> current,
            IEnumerable<KeyValuePair<TKey, TValue>> target)
            where TKey : notnull
        {
            foreach (var value in target)
            {
                current.Add(value.Key, value.Value);
            }
            return current;
        }

        public static bool TryGetPropertyValue(
            this PropertyInfo property,
            object data,
            out KeyValuePair<string, object> value)
        {
            var propValue = property.GetValue(data);
            value = KeyValuePair.Create(property.Name, propValue);
            return !string.IsNullOrWhiteSpace(propValue?.ToString());
        }

        public static bool IsEnumerableType(
            this Type type)
        {
            return (type.GetInterface(nameof(IEnumerable)) != null);
        }
    }
}
