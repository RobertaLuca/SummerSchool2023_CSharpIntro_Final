namespace CSharp_Training.Events;

public class EventsDemo
{
    /* TODO 17
     * Create an event
     * Create a full event
     * Trigger the created events
     * Examples already present for the usage cases
     */

    public Action? MyAction { get; set; }

    public event Action? MyEvent;

    private Action? _fullEvent;

    public event Action? FullEvent
    {
        add => _fullEvent += value; // multicast delegate, is just a list of delegates
        remove => _fullEvent -= value;
    }

    public void TriggerEvent()
    {
        MyEvent?.Invoke();
    }

    public void TriggerFullEvent()
    {
        _fullEvent?.Invoke();

        // FullEvent?.Invoke(); // error
    }
}

public static class Tester
{
    public static void TriggerAction()
    {
        EventsDemo demo = new();

        demo.MyAction += () => Console.WriteLine("Hello World!");

        demo.MyAction = null; // this may produce bugs

        demo.MyAction?.Invoke();
    }

    public static void TriggerEvent()
    {
        EventsDemo demo = new();

        demo.MyEvent += () => Console.WriteLine("Hello there!");

        // demo.MyEvent = null; // error

        demo.MyEvent += () => Console.WriteLine("Hello!");

        // demo.MyEvent?.Invoke(); // error

        demo.TriggerEvent();
    }
}
