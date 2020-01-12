using BoilerConvenienceFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerConvienceFinder.Data
{
	public class BoilerConvienceFinderContext : DbContext
	{
		public DbSet<ATMModel> ATM { get; set; }
		public DbSet<BankModel> Bank { get; set; }
		public DbSet<BuildingModel> Building { get; set; }
		public DbSet<LocationModel> Location { get; set; }
		public DbSet<VendingMachineModel> VendingMachine { get; set; }
		public DbSet<VendingMachineTypeModel> VendingMachineType { get; set; }

		//TODO: Make the connection string dynamic
		protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = C:\Source Control\Boiler-Convenience-Finder\BoilerConvenienceFinder\BoilerConvenienceFinder\Services\BoilerConvenienceFinder.mdf; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
	}
}
