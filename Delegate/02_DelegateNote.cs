namespace CsharpExample.Delegate
{
    class DelegateNote
    {
        //대리자 생성
        delegate void SayDel();

        //함수생성
        static void Hello() => System.Console.WriteLine("안뇽");

    static void Main(string[] args)
    {
            //대리자 지정
            SayDel sayDel = new SayDel(Hello); ////파라메터로 메서드를 받아야함, 어떤행동을 대리할지 알아야하니까
            sayDel();
            sayDel.Invoke();
    }
}
}
