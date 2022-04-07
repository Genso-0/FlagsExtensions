using System;

namespace FlagsTesting
{
    [Flags]
    public enum ExampleFlags
    {
        None = 0,
        A = 1 << 0,
        B = 1 << 1,
        C = 1 << 2,
        AB = A | B,
        ABC = AB | C,
    };
}
