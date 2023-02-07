// C# program to demonstrate the
// concept of Deep copy
using System;

namespace PracticeLibrary;

public static class DeepCopyC
{
	public static void DeepCopyMethod()
	{
		Company c1 = new Company(548, "GeeksforGeeks",
									"Sandeep Jain");
		// Performing Deep copy							
		Company c2 = (Company)c1.DeepCopy();

		Console.WriteLine("Before Changing: ");

		// Before changing the value of
		// c2 GBRank and CompanyName
		Console.WriteLine(c1.GBRank);
		Console.WriteLine(c2.GBRank);
		Console.WriteLine(c2.desc.CompanyName);
		Console.WriteLine(c1.desc.CompanyName);

		Console.WriteLine("\nAfter Changing: ");

		// changing the value of c2
		// GBRank and CompanyName
		c2.GBRank = 59;
		c2.desc.CompanyName = "GFG";

		// After changing the value of
		// c2 GBRank and CompanyName
		Console.WriteLine(c1.GBRank);
		Console.WriteLine(c2.GBRank);
		Console.WriteLine(c2.desc.CompanyName);
		Console.WriteLine(c1.desc.CompanyName);
	}
}