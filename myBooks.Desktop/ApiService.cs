using System.Threading.Tasks;

using Flurl.Http;

using myBooks.Model.Extensions;

namespace myBooks.Desktop
{
    public class ApiService
    {
        public static string KorisnickoIme { get; set; }
        public static string Lozinka { get; set; }

        private readonly string _route;

        public ApiService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search = null)
        {
            var url = $"{Properties.Settings.Default.ApiUrl}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.ApiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
        }

        public async Task<T> GetAction<T>(string action, object search = null)
        {
            var url = $"{Properties.Settings.Default.ApiUrl}/{_route}/{action}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.ApiUrl}/{_route}";

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.ApiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).PutJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Delete<T>(object id)
        {
            var url = $"{Properties.Settings.Default.ApiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(KorisnickoIme, Lozinka).DeleteAsync().ReceiveJson<T>();
        }
    }
}
