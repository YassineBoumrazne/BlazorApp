using BlazorApp.Shared;

namespace BlazorApp.Client.Services
{
    public interface IApplicationService
    {
        public List<FormFields> formFieldsList  { get; set; }
        public Task<string> login(LoginDTO loginDTO);
        public Task GetFormFiledsData();
    }
}
