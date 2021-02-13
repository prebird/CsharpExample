using System;


class Parent
{
    public void Say() => Console.WriteLine("부모_안녕하세요");
}

class Child : Parent
{
    
}


namespace Override
{
    class MethodOverride
    {
        static void Main()
        {
            Child child = new Child(); child.Say();
        }
    }
}
