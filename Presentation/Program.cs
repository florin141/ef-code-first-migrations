﻿using DataLayer;
using System;
using System.Collections.Generic;
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
			var context = new TwitterContext();
			context.Database.Initialize(true);
		}
	}
}