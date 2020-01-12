using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoilerConvenienceFinder.Models
{
	public class VendingMachineTypeModel
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(10)]
		public string Name { get; set; }

		public List<VendingMachineModel> VendingMachines { get; set; }
	}
}
