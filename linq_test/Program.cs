using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linq_test
{
	class Program
	{
		static void Main(string[] args)
		{  
			var db = new northwind_sampleEntities();
			//////////
			var fuu=
			db.Products.Distinct();
			Console.WriteLine(fuu);
			var selected = from c in db.Orders select c;

			foreach (var order in selected)
			{
				Console.WriteLine(order.OrderID+" " + order.ShipCountry);
			}
		}
	}
}
