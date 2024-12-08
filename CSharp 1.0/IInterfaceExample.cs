namespace CSharp_1._0
{
    internal interface IInterfaceExample
    {
         string FirstName { get; set; }

         string LastName { get; set; }

         string FullName { get; set; }

        event EventHandler InterfaceEvent;

        void SetPrivateAttributes(string firstName, string lastName);

        void Aboout();
    }
}
