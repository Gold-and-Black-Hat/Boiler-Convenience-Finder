using System.ComponentModel.DataAnnotations;

namespace BoilerConvenienceFinder.Models
{
	public class ATMModel
	{
		[Key]
		public int Id { get; set; }

		[StringLength(50)]
		public string Name { get; set; }

		public int LocationId { get; set; }
		public LocationModel Location { get; set; }

		public int BankId { get; set; }
		public BankModel Bank { get; set; }
	}
}
