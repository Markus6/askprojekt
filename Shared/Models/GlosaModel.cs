using System.ComponentModel.DataAnnotations;

namespace ASKProjekt.Shared.Models
{
	public class GlosaModel
	{
		public int Id { get; set; }
		[Required]
		public string Language1 { get; set; } = null!;
		[Required]
		public string Language2 { get; set; } = null!;
	}
}
