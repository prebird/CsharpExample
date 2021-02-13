using static System.Console;
namespace Interface
{
    //관례적으로 모든 인터페이스는 "I"로 시작
    public interface ICarStandard 
    {
        void Stop(); //액세스 한정자 붙히지 않음
    }
    abstract class KS
    {
        public abstract void Back(); //본문 선언불가 ,설계만
        //public void Fly() => WriteLine("날다"); // 구현도 가능
    }

    sealed class Car : KS, ICarStandard
    {
        public void Go() => WriteLine("가다");
        public override void Back() => WriteLine("후진");
        public void Stop() => WriteLine("멈춤");
    }

    class InterfaceExample
    {
        static void Main()
        {
            Car car = new Car();
            car.Go(); car.Back(); ; car.Stop();
        }
    }
}
