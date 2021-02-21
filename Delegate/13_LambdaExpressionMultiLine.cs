using System;

namespace LambdaExpressionMultiLine
{
    class LambdaExpressionMultiLine
    {
        delegate void Hi();
        static void Main(string[] args)
        {
            // 여러 줄은 중괄호로 묶음
            Hi hi = () =>
            {
                Console.WriteLine("안녕하세요");
                Console.WriteLine("오랜만입니다");
            };

            hi();

        }
    }
}
