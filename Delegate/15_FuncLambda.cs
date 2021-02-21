// [1] Func => 대리자 선언안해 줘도됨 
// [2] 메서드 선언안하는건 무명메서드 / 람다식
// [1] 와 [2]를 사용하면 둘다 안해도 됨 
using System;

// Func 형식 : Func<입력값 형식, 출력값 형식> 대리자이름
namespace FuncLambda
{
    class FuncLambda
    {
        static void Main(string[] args)
        {
            // 무명 메서드 담기
            Func<int, int> anonymous = delegate (int x) { return x * x; };

            // 람다식 담기
            Func<int, double> lambda = x => x / (double)2;     // 그냥 2로하면 1이 뜸 , (double)2로 해야 1.5가 뜸
            Console.WriteLine(lambda(3));
        }
    }
}
