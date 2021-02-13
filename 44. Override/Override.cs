using System;

namespace Override
{
    class Parent
    {
        protected void Say() => Console.WriteLine("부모_안녕");
        public void Run() => Console.WriteLine("부모_달리다");
        public virtual void Work() => Console.WriteLine("부모_프로그래머");
    }

    class Child : Parent
    {
        public void Say() => Console.WriteLine("자식_안녕");
        public new void Run() => Console.WriteLine("자식_달리다");
        // public override void Work() => base.Work(); // 관대한 부모의 의견을 따르는 경우
        public override void Work() => Console.WriteLine("게이머");
        //관대한 부모 존중, 자기 의견d
    }

    class Override
    {
        static void Main()
        {
            Child child = new Child();
            child.Say(); //자식이 예의가 없는 경우 부모x -> 자식x
            child.Run(); //자식이 예의가 있는 경우 부모x -> 자식 new
            child.Work(); //부모 virtual -> 자식 override -> good

        }
    } 
}