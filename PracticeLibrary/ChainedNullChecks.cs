using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary
{
    public class ChainedNullChecks
    {
        public static void Test1()
        {
            var list = new Random().Next(10) > 5 ? new List<Row>() : null;

            if (list is not null || list[0].Elements is null)
            {
                Console.WriteLine("yes");
            }
        }
    }
    public class Row
    {
        public IList<Element> Elements { get; set; }
        public class Element
        {
            public IList<Person> Persons { get; set; }

            public class Person
            {
                public string Name { get; set; }
            }
        }
    }
}
