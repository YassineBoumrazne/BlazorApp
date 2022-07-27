using BlazorApp.Shared;
using System.Net.Http.Json;

namespace BlazorApp.Client.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly HttpClient http;

        public ApplicationService(HttpClient http)
        {
            this.http = http;
        }
        public List<FormFields> formFieldsList { get; set; } = new List<FormFields>();

        public async Task GetFormFiledsData()
        {
            formFieldsList = new() { new() { Field1 = "David", Field2 = "David" }, new() { Field1 = "Mladen", Field2 = "David"}, new() { Field1 = "John", Field2 = "David" }, new() { Field1 = "Ana", Field2 = "David" }, new() { Field1 = "Jessica", Field2 = "David" } };
            //Get data
            //formFieldsList=await http.GetFromJsonAsync<List<FormFields>>("Get method url");
        }

        public async Task<string> login(LoginDTO loginDTO)
        {
            //post login and get token
            //var response = await http.PostAsJsonAsync("post login method url", login);
            return loginDTO.Email;
        }
    }
}
