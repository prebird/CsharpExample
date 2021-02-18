using System;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace CsharpExample
{
    class Restaurant
    {
        // 멀티스레드 - 비동기방식 (가장 오래걸리는 시간이 걸림)  
        public void MakeFood()
        {
            Console.WriteLine($"요리 시작");
            DateTime start = DateTime.Now; //시작시간

            void Egg() //함수 안에 함수?
            {
                Thread.Sleep(3000); WriteLine("달걀 3초");//지연기능

            }
            Thread t1 = new Thread(new ThreadStart(Egg)); //ThreadStart는 대리자함수

            void Soup()
            {
                Thread.Sleep(2000); WriteLine("국 2초");//지연기능

            }
            Thread t2 = new Thread(new ThreadStart(Soup));

            
            Thread t3 = new Thread(() =>
            {
                Thread.Sleep(4000); WriteLine("밥 4초");//람다식
            });

            t1.Start(); t2.Start(); t3.Start(); // async 비동기로 따로 실행
            t1.Join(); t2.Join(); t3.Join(); // await 다 끝날때 까지 대기

            Console.WriteLine($"요리 종료: {(DateTime.Now - start).TotalSeconds}");
            // 동기: 9초, 비동기: 4초

            Console.WriteLine($"식사 시작");
            //SinglePro(); //단일 CPU
            MultiPro(); // 멀티 CPU
            Console.WriteLine($"식사 종료: {(DateTime.Now - start).TotalSeconds}");


        }

        private void SinglePro()
        {
            for (int i = 0; i < 20000; i++) { WriteLine("수다"); }
        }

        private void MultiPro()
        {
            Parallel.For(0, 20_000, (i) => { WriteLine("수다"); });
        }

        
    }

    class ThreadNote
    {
        static void Main()
        {
            (new Restaurant()).MakeFood();
        }
    }
}
