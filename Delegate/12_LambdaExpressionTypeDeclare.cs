// = 뒤에 괄호안에는 파라메터
// => goes to 뒤 값들이 함수 내용

using System;

namespace LambdaExpressionTypeDeclare
{
    delegate bool Lambda(string msg, int len);
    class LambdaExpressionTypeDeclare
    {
        static void Main(string[] args)
        {
            Lambda print = (string msg, int len) => msg.Length > len;
            print("안녕하세요.", 5);   // true
            print("안녕하세요.", 10);  // false
        }
    }
}
