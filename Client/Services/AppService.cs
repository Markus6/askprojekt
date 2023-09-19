using ASKProjekt.Shared.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;

namespace ASKProjekt.Client.Services
{
	public class AppService : IAppService
	{
		private readonly HttpClient httpClient;
		public AppService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}
		public async Task<List<GlosaModel>?> GetGlosorAsync()
		{
			var result = await httpClient.GetFromJsonAsync<List<GlosaModel>>("api/glosor");

			if (result != null)
			{
				return result;
			}
			return null;
		}
	}
}
