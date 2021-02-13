
#define RELEASE // Release 모드 임을 가정

using System;
using System.Diagnostics;
using static System.Console;
using System.Reflection;

namespace AttributeAndReflection
{
    // 사용자 정의어트리뷰트 생성 - 멤버가 없으면 표시만하는 기능
    public class LuxuryAttribute : Attribute 
    {
        public LuxuryAttribute() => WriteLine("럭셔리!!");
    }

    [Luxury]
    class Car
    {
        [Obsolete("다음 버전에 제거될 예정이니 Auto()를 사용하세요")] 
        public void Manual() => WriteLine("수동운전");    // 1.0 verison
        // 주석처리와 달리 밑의 코드들이 에러가 나지 않음 
        public void Auto() => WriteLine("자동운전"); // 2.0 version
        [Conditional("DEBUG")] public void Test() => WriteLine("테스트 운전");
        [Conditional("RELEASE")] public void Test2() => WriteLine("테스트 운전");

    }
    class AttributeAndReflection
    {
        static void Main()
        {
            Car car = new Car();
            Attribute.GetCustomAttributes(typeof(Car));
            typeof(Car).GetCustomAttributes(false);
            car.Manual(); car.Auto();
            car.Test(); car.Test();

            //리플랙션 : 모든 멤버를 다 불러올 수 있음
            // 라이브러리나 API를 만들때 사용됨
            var carType = new Car();
            Type mycar = carType.GetType();
            MethodInfo info = mycar.GetMethod("Auto");
            info.Invoke(carType, null);
        }
    }
}
