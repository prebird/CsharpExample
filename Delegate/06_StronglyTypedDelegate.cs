using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExample.Delegate
{
    class StronglyTypedDelegate
    {
        // 강력한 형식의 대리자
        public delegate double DelegateType(double x, double y);

        static void Main()
        {
            // Math.Pow 는 몇승 계산
            // Pow 함수랑 같은 형식의 매개변수와 반환값
            DelegateType pow = Math.Pow;

            double result = pow(1.2, 3);

            Console.WriteLine(result);
        }
    }
}
