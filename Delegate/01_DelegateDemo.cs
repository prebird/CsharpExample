using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExample.deligate
{

    
    class Delegate
    {
        // [1] 기본형태
        static void Hi() => Console.WriteLine("안녕");
        delegate void HiDel();


        static void Main(string[] args)
        {
            //[1] -1 이름만 바꿔서 출력
            HiDel say = Hi;
            say();
            //[1] -2 이름만 바꿔서 출력
            var say1 = new HiDel(Hi);
            say1();
            say1.Invoke();



            
        }
    }
}
