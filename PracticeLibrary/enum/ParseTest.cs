using System;

public class ParseTest
{
    [Flags]
    enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };

    public static void parse()
    {
        Console.WriteLine("The entries of the Colors enumeration are:");
        foreach (string colorName in Enum.GetNames(typeof(Colors)))
        {
            Console.WriteLine("{0} = {1:D}", colorName,
                                         Enum.Parse(typeof(Colors), colorName));
        }
        Console.WriteLine();

        int orange = (int)Enum.Parse(typeof(Colors), "Red");
        Console.WriteLine("The orange value {0:D} has the combined entries of {0}",
                           orange);
    }
}

/*
This code example produces the following results:

The entries of the Colors Enum are:
Red = 1
Green = 2
Blue = 4
Yellow = 8

The orange value 9 has the combined entries of Red, Yellow

*/