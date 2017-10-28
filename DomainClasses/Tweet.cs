﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
	public class Tweet
	{
		public int Id { get; set; }
		public DateTime CreateDate { get; set; }
		public string Content { get; set; }
		public Alias Alias { get; set; }
		public int AliasId { get; set; }
	}
}
