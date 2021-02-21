using System;

namespace IntParameterAndIntReturnClass
{
    class IntParameterAndIntReturnClass
    {
        delegate int IntParameterDelegate(int x);

        static void Main(string[] args)
        {
            IntParameterDelegate pow = (x) => x * x;
            pow(3);
        }
    }
}
