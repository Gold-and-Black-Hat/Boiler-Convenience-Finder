﻿using Microsoft.EntityFrameworkCore;

namespace BoilerConvienceFinder.Data
{
	public class BoilerConvienceFinderContext : DbContext
	{
		//TODO: Make the connection string dynamic
		protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = C:\Users\magic\source\repos\Gold-and-Black-Hat\Boiler-Convience-Finder\BoilerConvienceFinder\BoilerConvienceFinder\Data\BoilerConvenienceFinder.mdf; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
	}
}
