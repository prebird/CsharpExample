using System;

namespace CsharpExample.Delegate
{   
    class DelegateParameter
    {
        //[?] 대리자(델리게이트)는 동일한 메서드 시그니처를 갖는 메서드의 참조를 담을 수 있는 그릇
        delegate void Run();
        static void Main(string[] args)
        {
            // 내가 만든 코드
            Run runnerGo = new Run(Go); //파라메터로 메서드를 받아야함
            Run runnerStop = new Run(Stop);
            RunnerCall(runnerGo);
            RunnerCall(runnerStop);

            //답
            RunnerCall(new Run(Go)); 
            RunnerCall(new Run(Stop));

            //new Run(Go); //이건 안됨   //위에는 파라메터 속에 있어서 되는건가?
        }

        static void RunnerCall(Run run) => run(); // Run 대리자 형식을 파라메터로 받음
        static void Go() => Console.WriteLine("달려");
        static void Stop() => Console.WriteLine("멈춰");
    }
}
