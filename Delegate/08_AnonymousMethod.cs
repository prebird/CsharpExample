// 무명 메서드 : 대리자를 축약해서 표현하는 법
// [1] 대리자에 파라메터로 들어가는 콜백 메서드를 따로 안만들어 줘도 됨
// [2] 대리자는 미리 선언해 줘야함 (묵시적 선언 var 안되서)

namespace AnonymousMethod
{
    class Print
    {
        public static void Show(string msg) => System.Console.WriteLine(msg);
    }

    class AnonymousMethod
    {
        //대리자의 파라메터는 콜백 메서드의 파라메터와 같아야함!
        delegate void PrintDelegate(string msg); 
        delegate void SumDelegate(int a, int b);

        static void Main(string[] args)
        {
            // 대리자에 메서드 등록 후 호출
            PrintDelegate pd = new PrintDelegate(Print.Show);
            pd("대리자 사용");
            // 무명메서드 사용
            PrintDelegate am = delegate (string msg)
            {
                System.Console.WriteLine(msg);
            };

            // 무명 메서드만 사용
            SumDelegate sd = delegate (int x, int y) { System.Console.WriteLine(x + y); };
            sd(5, 8);

        }
    }
}
