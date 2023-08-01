namespace CSharp_Training;

public class Generics
{
    /* TODO 13
     * Create a generic method with a parameter of a generic type
     * Create a generic method that can accept only classes as parameters
     */
    public void GenericMethod<T>(T value)
    {

    }

    public void GenericMethodWithConstraints<T>(T value) where T : class 
    {

    }
}

/* TODO 14
 * Create a generic class
 */
public class GenericClass<T>
{
    
}