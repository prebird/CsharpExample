using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExample.Delegate
{
    class Driver 
    {
        public static void Left() => Console.WriteLine("좌회전");  // 스태틱 메서드
        public static void Right() => Console.WriteLine("우회전");  
        public static void Boost() => Console.WriteLine("과속");
    }

    class Insa 
    {
        public void Bye() => Console.WriteLine("잘가");  // 스태틱 메서드 아님
    }

    // 대리자 생성, 클래스 레벨에서 생성
    delegate void GoHome();
    
    class DelegatePractice
    {
        // 대리자 생성, 클래스 안에 생성
        delegate void Meeting();

        private static void Hi() => Console.WriteLine("안녕");
        private static void LTNS() => Console.WriteLine("오랜만이다");

        static void Main(string[] args)
        {
            // [1] 그냥 호출
            Driver.Right();
            Driver.Left();
            Driver.Boost();

            Console.WriteLine();

            // [2] 대리자 선언 할당 같이
            //Driver driver = new Driver(); // static으로 만들면 인스턴트 만들지 X
            // 집가는 대리자 생성
            GoHome goHome = new GoHome(Driver.Left);
            goHome += Driver.Right;
            goHome += Driver.Boost;
            goHome.Invoke();

            Console.WriteLine();

            //[3] 대리자 선언, 할당 따로
            Meeting meeting;
            meeting = new Meeting(Hi);
            meeting += LTNS;
            meeting();

            Console.WriteLine();

            //[4] 스태틱 메서드 아닐때
            Insa insa = new Insa();
            Meeting meeting2 = new Meeting(insa.Bye); // 다른 대리자는 인스턴트 이름 다르게 생성
            meeting2();

        }
    }
}
