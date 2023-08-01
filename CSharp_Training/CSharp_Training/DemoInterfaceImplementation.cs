namespace CSharp_Training;

/* TODO 3 
 * Create a public class DemoInterfaceImplementation that implements IDemoInterface in the classic way
 * Create a public class DemoInterfaceImplementation2 that implements explicitly IDemoInterface
 * Examples already present for the usage cases
 */

public class DemoInterfaceImplementation : IDemoInterface
{
    public void RightInterfaceMethod()
    {
        Console.WriteLine("Hello World!");
    }
}

public class DemoInterfaceImplementation2 : IDemoInterface
{
    void IDemoInterface.RightInterfaceMethod()
    {
        Console.WriteLine("Hello World!");
    }
}

public class Tester
{
    public static void Test()
    {
        IDemoInterface demoInterface = new DemoInterfaceImplementation();
        demoInterface.RightInterfaceMethod();

        DemoInterfaceImplementation demoInterfaceImplementation = new();

        demoInterfaceImplementation.RightInterfaceMethod();
    }

    public static void Test2()
    {
        IDemoInterface demoInterface = new DemoInterfaceImplementation2();
        demoInterface.RightInterfaceMethod();

        DemoInterfaceImplementation2 demoInterfaceImplementation2 = new();

        //demoInterfaceImplementation2.RightInterfaceMethod();
    }
}
