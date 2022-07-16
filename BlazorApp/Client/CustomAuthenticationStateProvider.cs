using BlazorApp.Client.Services;
using BlazorApp.Shared;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BlazorApp.Client
{
    public class CustomAuthenticationStateProvider:AuthenticationStateProvider
    {
        private readonly ISessionStorageService sessionStorage;

        public CustomAuthenticationStateProvider(ISessionStorageService sessionStorage)
        {
            this.sessionStorage = sessionStorage;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            var result = await sessionStorage.GetItemAsync<string>("token");
                
            if (result!=null)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim("email", result),
                }, "Authentication");
            }

            var state = new AuthenticationState(new ClaimsPrincipal(identity));
            NotifyAuthenticationStateChanged(Task.FromResult(state));
            return state;

        }

    }
}
