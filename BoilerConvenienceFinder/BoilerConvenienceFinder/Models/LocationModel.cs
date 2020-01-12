using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoilerConvenienceFinder.Models
{
	public class LocationModel
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(1)]
		public string Floor { get; set; }

		[StringLength(5)]
		public string RoomNumber { get; set; }

		public int BuildingId { get; set; }
		public BuildingModel Building { get; set; }

		public List<VendingMachineModel> VendingMachines { get; set; }

		public List<ATMModel> ATMs { get; set; }
	}
}
