using System;
using System.Collections.Generic;

namespace Tuple
{
    class Tuple
    {
        static void Main()
        {
            static (int, int) Tally1()
            {
                var r = (12, 3);
                return r;
            }

            var t1 = Tally1();
            Console.WriteLine(t1);

        }
    }
}
