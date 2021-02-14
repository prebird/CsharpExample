using System;


namespace ExtensionMethod
{
    static class StringExtension
    {
        public static string Five(this string msg) => msg.Substring(0, 5);
        public static string Ten(this string msg) => msg.Substring(0, 10);
        public static string AddElipsis(this string msg) => msg + "...";
        // 매개변수도 받기
        public static string AddElipsis(this string msg, string el) => $"{msg} {el}씨";
    }

    class ExtensionMethod
    {
        static void Main()
        {
            string message = "안녕하세요 반갑습니다 또 만나요";
            Console.WriteLine(message.Ten().Five().AddElipsis());
            // 매개변수도 받기
            Console.WriteLine(message.Ten().Five().AddElipsis("정용규"));


        }
    }
}
