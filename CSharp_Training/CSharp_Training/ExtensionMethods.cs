namespace CSharp_Training;

/* TODO 15
 * Extensions
 */

public static class ExtensionMethods // must be static
{
    public static void Hello<T>(this IEnumerable<T> values)
    {
        foreach (var value in values)
        {
            Console.WriteLine(value);
        }
    }
}

public static class ExtensionDemo
{
    public static void Demo()
    {
        List<int> list = new() { 1, 2, 3 };
        Dictionary<int, int> dict = new() { { 1, 2 }, {  3, 4 } };

        dict.Hello();

        list.Hello();

        // at compile time it will be converted to:
        // ExtensionMethods.Hello(list)
    }
}
