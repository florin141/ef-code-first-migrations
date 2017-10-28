using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
	public class TwitterRevenue
	{
		public int Id { get; set; }
		public decimal Amount { get; set; }
		public DateTime Date { get; set; }
	}
}
