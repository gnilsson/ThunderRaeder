using System.Net.Http;
using System.Text;
using System.Text.Json;
using ThunderRaeder.Client.Descriptive;

namespace ThunderRaeder.Client.Models.PostRequests
{
    public interface IPostRequest<T>
    {
        public T ToRequest();

        public virtual StringContent ToStringContent()
        {
            return new StringContent(JsonSerializer.Serialize(this.ToRequest()), Encoding.UTF8, HttpContentType.ApplicationJson);
        }
    }
}
