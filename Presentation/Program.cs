using DataLayer;
using DataLayer.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
	class Program
	{
		static void Main(string[] args)
		{
			CreateDatabase();
		}

		private static void CreateDatabase()
		{
			//Database.SetInitializer(new MigrateDatabaseToLatestVersion<TwitterContext, Configuration>());
			var context = new TwitterContext();
			context.Database.Initialize(true);
		}
	}
}
