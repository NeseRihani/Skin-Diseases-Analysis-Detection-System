using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
	public class SkinAnalyseContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-95TG6R7\\SQLEXPRESS;initial catalog=SDD;integrated security=true;TrustServerCertificate=True;");
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Photo> Photos { get; set; }
		public DbSet<Login> Logins { get; set; }
		public DbSet<AnalyseResult> AnalyseResults { get; set; }
		public DbSet<AIHistory> AIHistories { get; set; }
	}
}
