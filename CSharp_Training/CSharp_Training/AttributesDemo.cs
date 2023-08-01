namespace CSharp_Training;

/* TODO 18
 * Attributes & Reflection
 */

/* TODO
 * Create standard attribute, make it public
 */

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class FancyClassAttribute : Attribute
{

}

/* TODO
 * Create a class and add the created attribute (no need to specify Attribute at the end)
 */

[FancyClass]
class MyClass
{

}

class DemoReflection
{
	public static void ReflectionExample()
	{
		var assembly = typeof(MyClass).Assembly;
		var types = assembly.GetTypes().Where(x => x.CustomAttributes.Where(a => a.AttributeType == typeof(FancyClassAttribute)).Any());

		foreach (var type in types)
		{
			_ = Activator.CreateInstance(type);
		}
	}
}
