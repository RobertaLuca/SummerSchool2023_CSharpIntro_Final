namespace CSharp_Training;

public class BoxingDemo
{
    /* TODO 11
     * Boxing = a value type is converted to reference type; behind the scenes a copy is made on the heap!!!!
        * Examples 
     * Unboxing = a reference type is converted to value type
        * Examples
     */
    public void Boxing() // 
    {
        Console.WriteLine($"Hello {1} {2}"); // boxing

        Console.WriteLine($"Hello {1.ToString()}"); // no boxing

        int a = 10;

        object b = a; // boxing 
    }

    public void Unboxing() // a reference type is converted to value type
    {
        object a = 10;

        int b = (int)a; // unboxing
    }
}


