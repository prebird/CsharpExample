using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExample.Delegate
{
    
    

    class FunctionPointer
    {   
        // 함수 포인터 형식
        delegate void Whats();

        static void Main(string[] args)
        {
            // 함수 포인터 정의
            // new 필요없음
            Whats whats = delegate { Console.WriteLine("함수포인터 == 대리자"); };

            // 함수 포인터 호출
            whats();
        }


    }
}
