using System;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Net.Http.Headers;
using System.Collections.Generic;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication;

using myBooks.Model;
using myBooks.API.Services;

namespace myBooks.API.Security
{
    public class DefaultAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IPrijavaService _prijavaService;

        public DefaultAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IPrijavaService prijavaService)
            : base(options, logger, encoder, clock)
        {
            _prijavaService = prijavaService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            PrijavljeniKorisnik prijavljeniKorisnik;

            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');

                var korisnickoIme = credentials[0];
                var lozinka = credentials[1];
                
                prijavljeniKorisnik = await _prijavaService.Autentificiraj(korisnickoIme, lozinka);
            }
            catch
            {
                return AuthenticateResult.Fail("Neispravan autentifikacijski header");
            }

            if (prijavljeniKorisnik == null)
                return AuthenticateResult.Fail("Netačno korisničko ime i/ili lozinka");

            var claims = new List<Claim> {
                new Claim("Id", prijavljeniKorisnik.KorisnikId.ToString()),
                new Claim(ClaimTypes.NameIdentifier, prijavljeniKorisnik.KorisnickoIme),
                new Claim(ClaimTypes.Name, prijavljeniKorisnik.Ime),
                new Claim(ClaimTypes.Role, prijavljeniKorisnik.Uloga.ToString()),
            };

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);
            
            return AuthenticateResult.Success(ticket);
        }
    }
}
