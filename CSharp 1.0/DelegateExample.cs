namespace CSharp_1._0
{
    internal class DelegateExample
    {
        public DelegateExample()
        {
            Console.WriteLine("*************************DELEGATE**************************");
        }

        public void About()
        {
            Console.WriteLine("A delegate is a type that represents references to methods with a particular parameter list and return type. When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type.\n" +
                " You can invoke (or call) the method through the delegate instance");
        }

        public int Addition(int fisrt, int second)
        {
            return fisrt + second;
        }

        public int Subtraction(int fisrt, int second)
        {
            return fisrt - second;
        }
    }
}
