namespace CSharp_Training;

/* TODO 2
 * Create a public interface IDemoInterface
 * 2 kind of methods: with and without implementation (void, no parameters)
 */

public interface IDemoInterface
{
    public void RightInterfaceMethod();

    public void DoNotEvenThinkAboutUsingThisSyntax()
    {
        Console.WriteLine("What have you done :(");
    }
}
