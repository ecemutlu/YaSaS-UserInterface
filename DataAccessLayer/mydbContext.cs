using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer
{
	public class mydbContext : IdentityDbContext
	{
		public mydbContext(DbContextOptions<mydbContext> options)
		: base(options)
		{

		}
		public DbSet<Building> Building { get; set; }
		public DbSet<Sensor> Sensor { get; set; }
		public DbSet<Data> Data { get; set; }
		public DbSet<City> City { get; set; }
		public DbSet<Town> Town { get; set; }
	}
}
