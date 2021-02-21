// [?] 람다식: 매개변수도 있고 반환값도 있는 경우
using System;

namespace LambdaExpressionArgs
{
    // 대리자 선언
    delegate int Lambda(int i);
    class LambdaExpressionArgs
    {
        static void Main(string[] args)
        {
            // 대리자 개채 생성
            Lambda square = x => x * x;
            Console.WriteLine(square(4));

        }
    }
}
