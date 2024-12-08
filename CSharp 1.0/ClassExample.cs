namespace CSharp_1._0
{
    internal class ClassExample
    {
        private string _firstName { get; set; }

        private string _lastName { get; set; }

        public string FullName = "FirstName LastName";

        public ClassExample()
        {
            Console.WriteLine("*************************CLASS**************************");
        }

        public void SetPrivateAttributes(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            Console.WriteLine("Set attributes FirstName:" + _firstName + " LastName: " + _lastName);
            FullName = _firstName + " " + _lastName;
        }

        public void Aboout()
        {
            Console.WriteLine("Definition: Class defines a type of object.\n" +
                "It serves as template or blue print of object.\n" +
                "It defines structre,behavior and attributes of object.\n" +
                "It encapsulates attributes(properties/data members) and methods.\n" +
                "Intialize class object with help of new keyword and class constructor.\n" +
                "Default value of class object is null value.\n" +
                "Class is refrense type stored in heap memory."
                );

            Console.WriteLine("Attributes defined within class and provides internal state");

            Console.WriteLine("Class default access modifier is internal.\n" +
                "It means class can be accessed within namespace.");

            Console.WriteLine("Access Modifiers are\n" +
                "Public: Members are accessible from within or outside the assembly(any code).\n" +
                "Private: Members are accessible within the class.\n" +
                "Potected: Members are accessible within the class and inherited class.\n" +
                "Internal: Members are accessible within the assembly.\n" +
                "Protected Internal: Members are accessible within the assembly and inherited class.\n");

            Console.WriteLine("Mthods are defined within class.\n" +
             "Performs actions or operations and can modify class state or functionality");
        }
    }
}
