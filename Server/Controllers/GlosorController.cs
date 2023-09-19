using ASKProjekt.Server.Repo;
using ASKProjekt.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASKProjekt.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GlosorController : ControllerBase
	{
		private readonly IGlosorRepo repo;
		public GlosorController(IGlosorRepo repo) 
		{
			this.repo = repo;
		}

		[HttpGet]
		public async Task<ActionResult<List<GlosaModel>?>> GetGlosorAsync()
		{
			var result = await repo.GetGlosorAsync();
			if (result != null)
			{
				return Ok(result);
			}
			else
			{
				return BadRequest();
			}
		}
	}
}
