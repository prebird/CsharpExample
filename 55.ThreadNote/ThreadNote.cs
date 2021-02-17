using System;

namespace CsharpExample
{
    class Restaurant
    {
        public void MakeFood()
        {
            Console.WriteLine($"요리 시작");
            Console.WriteLine($"요리 종료");
        }
    }

    class ThreadNote
    {
        static void Main()
        {
            (new Restaurant()).MakeFood();
        }
    }
}
