using Microsoft.EntityFrameworkCore;
using ASKProjekt.Server.Data;
using ASKProjekt.Shared.Models;

namespace ASKProjekt.Server.Repo
{
	public class GlosorRepo : IGlosorRepo
	{
		private readonly GlosorDbContext context;

		public GlosorRepo(GlosorDbContext context)
		{
			this.context = context;
		}
		public async Task<List<GlosaModel>?> GetGlosorAsync()
		{
			return await context.Glosor.ToListAsync();
		}

	}
}
