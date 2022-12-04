using System;
using Microsoft.EntityFrameworkCore;

namespace Final
{
	public class  AppDbContext : DbContext
	{
		public AppDbContext (DbContextOptions<  AppDbContext> options)
			: base(options)
		{
		}
		public DbSet <Team> Team {get; set;} = default!;
        public DbSet <Player> Player {get; set;} = default!;
	}
}
