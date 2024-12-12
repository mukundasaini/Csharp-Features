namespace CSharp_1._0
{

    internal class CustomEventArgs : EventArgs
    {
        public string Message { get; set; }
    }

    internal class EventExample
    {

        public event EventHandler OnEvent;

        public event EventHandler<CustomEventArgs> OnCustomEventArgs;

        public EventExample()
        {
            Console.WriteLine("*************************EVENT**************************");
        }

        public void DefaultEventInvoke(EventArgs e, string type)
        {
            Console.WriteLine("Event will trigger here. Event type" + type);
            if (OnEvent != null)
                OnEvent.Invoke(this, e);
        }

        public void SetCustomEventMessage(CustomEventArgs e)
        {
            Console.WriteLine("Custom Event args example Event will trigger here. Event type" + e.Message);
            if (OnCustomEventArgs != null)
                OnCustomEventArgs.Invoke(this, e);
        }


        public void About()
        {
            Console.WriteLine("Events enable a class or object to notify other classes or objects when something of interest occurs.\n" +
                " The class that sends (or raises) the event is called the publisher and the classes that receive (or handle) the event are called subscribers.");

            Console.WriteLine("An event is a member that enables an object to trigger notifications.\n" +
                " Event users can attach executable code for events by supplying event handlers");
        }
    }
}
