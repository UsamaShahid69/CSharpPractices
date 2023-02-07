namespace PracticeLibrary
{
    public static class AssigningObjects
    {
        public static void AssignObMethod()
        {
            Person person1 = new Person
            {
                Name = "ali",
                Children = new List<Child>()
                {
                    new Child() { FirstName = "Usman", LastName = "Shahid" }
                }
            };
            Person person1Copy = new();
            person1Copy.Children = new List<Child>()
                {
                    new Child() { FirstName = "Megy", LastName = "Moron" }
                };
            person1Copy = person1;
            Console.WriteLine("done");

        }
    }

    public class Person
    {
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty ;
        public List<Child> Children { get; set; }
    }

    public class Child
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}