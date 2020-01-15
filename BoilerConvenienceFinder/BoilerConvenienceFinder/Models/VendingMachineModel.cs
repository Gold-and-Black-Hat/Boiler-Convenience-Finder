using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BoilerConvenienceFinder.Models
{
	public class VendingMachineModel
	{
		[Key]
		public int Id { get; set; }

		[StringLength(50)]
		public string Name { get; set; }

		public int LocationId { get; set; }
		public LocationModel Location { get; set; }

		public int VendingMachineTypeId { get; set; }
		public VendingMachineTypeModel VendingMachineType { get; set; }
	}
}
