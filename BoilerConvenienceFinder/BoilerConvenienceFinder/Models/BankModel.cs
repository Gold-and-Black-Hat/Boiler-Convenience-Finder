using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoilerConvenienceFinder.Models
{
	public class BankModel
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		public List<ATMModel> ATMs { get; set; }
	}
}
