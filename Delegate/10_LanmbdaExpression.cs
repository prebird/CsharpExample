// 람다 식(Lambda Expression): C# 3.0에 도입됨
// 무명메서드와 같이 콜백메서드를 따로 등록하지 않아도 됨
using System;

namespace LanmbdaExpression
{
    class LanmbdaExpression
    {
        // 대리자 선언
        delegate void Lambda();
        static void Main(string[] args)
        {
            // 대리자 개체에 람다식 정의 : goes to
            Lambda lambda = () => { Console.WriteLine("람다식"); };
            lambda();
        }
    }
}

