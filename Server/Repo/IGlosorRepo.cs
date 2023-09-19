using ASKProjekt.Shared.Models;

namespace ASKProjekt.Server.Repo
{
	public interface IGlosorRepo
	{
		Task<List<GlosaModel>?> GetGlosorAsync();
	}
}
