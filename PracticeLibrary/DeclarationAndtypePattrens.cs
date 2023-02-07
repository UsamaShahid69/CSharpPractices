using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary;

public class DeclarationAndtypePattrens
{
	public static string Hello { get; set; }
	public DeclarationAndtypePattrens()
	{
		Hello= "Hello";
	}
	
	public DeclarationAndtypePattrens(string me)
	{
		Hello= me;
	}

	public static void Test1()
	{
		if(Hello is string message)
		{
			Console.WriteLine(message);
		}
		else { Console.WriteLine(Hello); }
	}



	/// <summary>
	/// The run-time type of an expression result is T.

    //The run-time type of an expression result derives from type T, implements interface T, or another implicit reference conversion exists from it to T.The following example demonstrates two cases when this condition is true:
	/// </summary>
	public static void Test2()
	{
        var numbers = new int[] { 10, 20, 30 };
        Console.WriteLine(GetSourceLabel(numbers));  // output: 1

        var letters = new List<char> { 'a', 'b', 'c', 'd' };
        Console.WriteLine(GetSourceLabel(letters));  // output: 2
    }

    static int GetSourceLabel<T>(IEnumerable<T> source) => source switch
    {
        Array array => 1,
        ICollection<T> collection => 2,
        _ => 3,
    };

    string WaterState(int tempInFahrenheit) =>
    tempInFahrenheit switch
    {
        (> 32) and (< 212) => "liquid",
        < 32 => "solid",
        > 212 => "gas",
        32 => "solid/liquid transition",
        212 => "liquid / gas transition",
    };

	public string CalculateDiscount(Product product) => product switch
    {
        { Name: "ali" } => "liquid",
        null => throw new ArgumentNullException(nameof(product)),
        { Price: > 50 } => "OK",
        _ => throw new NotImplementedException()
    };

    public void ReadRecord()
    {

    }
}
