namespace CSharp_1._0
{
    internal class InterfaceExample : IInterfaceExample
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public event EventHandler InterfaceEvent;

        public InterfaceExample()
        {
            Console.WriteLine("*************************INTERFACE**************************");
        }


        public void SetPrivateAttributes(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine("Set attributes FirstName:" + FirstName + " LastName: " + LastName);
            FullName = FirstName + " " + LastName;
        }

        public void Aboout()
        {
            Console.WriteLine("An interface in C# is a contract that defines a set of methods, properties, events," +
                " and indexers that a class or struct must implement.\n" +
                "Interfaces cannot be instantiated directly"
                );

            Console.WriteLine("Interfaces specify what a class must do and not how.\n" +
                "Interfaces can’t have private members.\n" +
                "By default all the members of Interface are public and abstract.\n" +
                "The interface will always defined with the help of keyword ‘interface‘.\n" +
                "Interface cannot contain fields because they represent a particular implementation of data.\n" +
                "Multiple inheritance is possible with the help of Interfaces but not with classes.\n" +
                "An interface cannot contain constants, fields.");
        }
    }
}
