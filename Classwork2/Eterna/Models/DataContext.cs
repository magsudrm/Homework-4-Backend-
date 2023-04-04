using Microsoft.EntityFrameworkCore;

namespace Eterna.Models
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<TeamMember> TeamMembers { get; set; }
	}
}
