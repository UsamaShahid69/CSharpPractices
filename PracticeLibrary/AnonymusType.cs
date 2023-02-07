using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary;

public static class AnonymusType
{
	public static void Mutation()
	{
		var apple = new { item = "apple", price = 33 };
		var onSale = apple with { price = 20 };
		Console.WriteLine(apple.ToString());
		Console.WriteLine(onSale);
	}
}
