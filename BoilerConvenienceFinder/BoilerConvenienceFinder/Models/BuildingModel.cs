using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoilerConvenienceFinder.Models
{
	public class BuildingModel
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(4)]
		public string Code { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[Required]
		[StringLength(50)]
		public string StreetAddress { get; set; }

		public List<LocationModel> Locations { get; set; }
	}
}
