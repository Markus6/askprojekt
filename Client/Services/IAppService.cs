using ASKProjekt.Shared.Models;

namespace ASKProjekt.Client.Services
{
	public interface IAppService
	{
		Task<List<GlosaModel>?> GetGlosorAsync();
	}
}
