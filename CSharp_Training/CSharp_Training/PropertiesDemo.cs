namespace CSharp_Training.Properties;

public class PropertiesDemo
{
    /* TODO 4
     * Create an auto prop
     * Create a full expression prop (public getter, protected setter)
     * Initialization methods (ok in constructor + error in test class)
     */

    public int AutoProp { get; set; }

    private int _fullExpresion;

    public int FullExpresion
	{
		get => _fullExpresion;
		protected set => _fullExpresion = value;
	}

    public PropertiesDemo()
    {
        FullExpresion = 1;
    }
}

public static class Tester
{
    public static void ClassicInit()
    {
        PropertiesDemo demo = new();

        demo.AutoProp = 1;
        // demo.FullExpresion = 3; // error

        PropertiesDemo demo2 = new()
        {
            AutoProp = 1
        };
    }
}
