namespace CSharp_1._0
{
    internal struct StructureExample
    {
        private string _firstName { get; set; }

        private string _lastName { get; set; }

        public string FullName = "FirstName LastName";

        public event Action<string, string> StructEvent;

        public string[] Names = new string[2];

        public string this[int i] { get { return Names[i]; } set { Names[i] = value; } }

        public StructureExample()
        {
            Console.WriteLine("*************************STRUCT**************************");
        }

        public void SetPrivateAttributes(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            Console.WriteLine("Set attributes FirstName:" + _firstName + " LastName: " + _lastName);
            FullName = _firstName + " " + _lastName;
            StructEvent(firstName, lastName);
        }

        public void Aboout()
        {
            Console.WriteLine("struct can include constructors, constants, fields, methods, properties, " +
                "indexers, operators, events & nested types.\n" +
                "struct cannot include a parameterless constructor or a destructor.\n" +
                "struct can implement interfaces, same as class.\n" +
                "struct cannot inherit another structure or class, and it cannot be the base of a class.\n" +
                "struct members cannot be specified as abstract, sealed, virtual, or protected."
                );
        }

    }
}
