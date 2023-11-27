using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2023_ca1_71205.Models
{
	public class Client
	{
		public string Name { get; set; }
		public string CustomerID { get; set; }
		public override string ToString()
		{
			return
				$"Name.......: {Name}\n" +
				$"Customer ID: {CustomerID}\n" +
				$"============================================================================";
		}
	}
}
