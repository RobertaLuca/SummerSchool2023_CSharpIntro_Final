namespace CSharp_Training;

public class NullableDemo
{
    /* TODO 9
     * Create a nullable int
        * int is a value type, by default null values are not allowed, but by marking with "?" it will be nullable
        * check if it has a value using the proper method
     * Create a nullable string
        * string are reference types, null values are possible by default, but by marking with ? it will tell the compiler to generate warnings if null cases are not treated    
        * print the length of the string; check if it is not null (2 methods)
     * Create a string member and initialize it with null; then, tell the compiler that there are no cases in which that variable will be null
     */

    private string str3 = null!;

    public void Test()
    {
        int? integer = null;
        if (integer.HasValue)
        {
            int integerValue = integer.Value;
        }

        string str1 = null!;

        string? str = null;

        if (str is not null) 
        {
            Console.WriteLine(str.Length);
        }

        Console.WriteLine(str?.Length);
    }
}
