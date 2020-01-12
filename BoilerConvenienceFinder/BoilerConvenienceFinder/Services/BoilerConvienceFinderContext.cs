using Microsoft.EntityFrameworkCore;

namespace BoilerConvienceFinder.Data
{
	public class BoilerConvienceFinderContext : DbContext
	{
		//TODO: Make the connection string dynamic
		protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = C:\Source Control\Boiler-Convenience-Finder\BoilerConvenienceFinder\BoilerConvenienceFinder\Services\BoilerConvenienceFinder.mdf; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
	}
}
