using System;

public enum CarType { 전기, 내연기관 }

//추상 클래스 : 상속줄 목적으로만 만드는것
public abstract class CarBase
{
    
    public void Back() => Console.WriteLine("후진하다");
}


public class Car : CarBase
{
    public CarType Style { get; private set; }
    public Car(CarType carType) //카타입 새로 지정
    {
        this.Style = carType;
    }
    public void Go() => Console.WriteLine("달리다");
}

public class Benz : Car
{

    public Benz() : this(CarType.내연기관) { }
    public Benz(CarType carType) : base(carType) { }
    
}

public class Tesla : Car
{
    public Tesla() : this(CarType.전기){}
    public Tesla(CarType cartype) : base(cartype){ }
}

//봉인(최종)클래스
public sealed class Future : Car
{
    public Future() : this(CarType.전기) { }
    public Future(CarType carType) : base(carType) { }
    public new void Go()
    {
        base.Go(); Console.WriteLine("날다");
    }
    protected string LeftMessage { get; private set; } = "좌회전";
        
}


class Program
{
    static void Main()
    {
        Benz benz = new Benz(CarType.전기); benz.Go(); 
        Console.WriteLine($"{benz.Style}");
        Future future = new Future(); future.Go();

    }
}