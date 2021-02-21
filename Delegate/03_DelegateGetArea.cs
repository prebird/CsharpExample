using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExample.Delegate
{
    
    class DelegateGetArea
    {
        // 반환값과 매개변수가 있는 메서드
        static double GetArea(int r) => 3.14 * r * r;

        // 반환값과 매개변수가 있는 대리자
        delegate double GetAreaPointer(int r);

        static void Main(string[] args)
        {
            GetAreaPointer getAreaPointer = new(GetArea);
            getAreaPointer(10);
            getAreaPointer.Invoke(10);
        }

    }
}
