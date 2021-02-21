using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExample.Delegate
{
    class AnonymousDelegate
    {
        // 무명메서드 만들기
        delegate void SayDelegate();

        static void Main(string[] args)
        {
            // 암시적으로 변수할당(var)은 무명메서드 사용 불가
            // 콜백메서드를 선언안해줘도 됨
            SayDelegate say = delegate ()
            {
                Console.WriteLine("안녕");
            };
        }
    }
}
