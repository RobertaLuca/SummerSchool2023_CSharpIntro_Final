namespace CSharp_Training.Optimizations;

/* TODO 12
 * Const vs. Readonly
 */

public sealed class ConstVsReadonly // sealed does not allow inheritance, some optimization can be done behind the scenes
{
    private const int _a = 10; // must be a constant or an expression that can be evaluated at compile time,
                               // works similar with a macro from C++ (#define), so it will be inlined
                               // can be more efficient, both from a memory and performance perspective

    private readonly int _b = 20; // cannot be changed during runtime, similar with the "const" from C++

    // private const int _c; // error, not initialized

    private readonly int _d;

    public ConstVsReadonly(int value)
    {
        _d = value;
    }
}
