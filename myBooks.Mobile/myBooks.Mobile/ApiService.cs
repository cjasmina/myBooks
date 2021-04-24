using System.Threading.Tasks;

using Flurl.Http;
using Xamarin.Forms;

using myBooks.Model.Extensions;

namespace myBooks.Mobile
{
    public class ApiService
    {
        public static string KorisnickoIme { get; set; }
        public static string Lozinka { get; set; }

        private readonly string _route = null;
        private readonly string _apiUrl = "http://localhost:27322/api";

        public ApiService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search = null)
        {
            var url = $"{_apiUrl}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
        }

        public async Task<T> GetAction<T>(string action, object search = null)
        {
            var url = $"{_apiUrl}/{_route}/{action}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).PutJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Delete<T>(int id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).DeleteAsync().ReceiveJson<T>();
        }

        public async Task<T> DeleteWithRequest<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}?{await request.ToQueryString()}";

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).DeleteAsync().ReceiveJson<T>();
        }

        public async Task<T> DeleteAction<T>(string action, int id)
        {
            var url = $"{_apiUrl}/{_route}/{action}/{id}";

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).DeleteAsync().ReceiveJson<T>();
        }

        public async Task<T> DeleteActionWithRequest<T>(string action, object request)
        {
            var url = $"{_apiUrl}/{_route}/{action}?{await request.ToQueryString()}";

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).DeleteAsync().ReceiveJson<T>();
        }
    }
}
