using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsEG
{
    public delegate void MyEventHandler(object sender, MyEventArgs e);

    // Define the event arguments class
    public class MyEventArgs : EventArgs
    {
        public string Message { get; }

        public MyEventArgs(string message)
        {
            Message = message;
        }
    }

    // Define the publisher class
    public class EventPublisher
    {
        // Define the event using the delegate
        public event MyEventHandler MyEvent;

        // Method to raise the event
        public void RaiseEvent(string message)
        {
            OnMyEvent(new MyEventArgs(message));
        }

        // Method to invoke the event
        protected virtual void OnMyEvent(MyEventArgs e)
        {
            MyEvent?.Invoke(this, e);
        }
    }

    // Define the subscriber class
    public class EventSubscriber
    {
        // Event handler method
        public void HandleEvent(object sender, MyEventArgs e)
        {
            Console.WriteLine($"Event handled: {e.Message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of publisher and subscriber
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();

            // Subscribe to the event using the delegate method
            publisher.MyEvent += new MyEventHandler(subscriber.HandleEvent);

            // Raise the event
            publisher.RaiseEvent("Hello, world!");

            // Unsubscribe from the event
            publisher.MyEvent -= new MyEventHandler(subscriber.HandleEvent);
        }
    }
}
