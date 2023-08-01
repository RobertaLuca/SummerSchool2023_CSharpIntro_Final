namespace CSharp_Training;

public class IsDemo
{
    public void IsTypeChecking()
    {
        /* TODO 10
         * Create a variable of type object and initialize it with 1
         * Check if that object is a string and convert it to a string (2 methods)
         
         * something as string <=> (something is string) ? (string)something : null
         */

        object something = 1;

        if (something is string)
        {
            string a = (string)something;
        }

        if (something is string b)
        {
        }

        string c = something as string;


        // int a = something as int; // error

        int d = (int)something; // no type checking

        if (something is int e) // better
        {
        }
    }
}
