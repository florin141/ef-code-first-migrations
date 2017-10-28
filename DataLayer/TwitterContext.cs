using DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TwitterContext : DbContext
    {
		public DbSet<Alias> Aliases { get; set; }
		public DbSet<Tweet> Tweets { get; set; }
		public DbSet<TwitterRevenue> TwitterRevenues { get; set; }
	}
}
