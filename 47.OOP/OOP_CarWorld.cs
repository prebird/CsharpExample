using System.Collections;
using static System.Console;

//[1] 네임스페이스: 클래스명 충돌 방지

namespace OOP
{
    //[2] 인터페이스: 표준, 다중상속
    interface IStandard { void Run(); } //추상화 : 상속대기

    //[3] 클래스: 설계도
    class Car : IStandard
    {
        //캡슐화 : 숨기기
        #region [4] 필드: Private Member Variables
        private string name; //필드: 부품
        private string[] names; //배열형
        private readonly int _Length; //읽기전용
        #endregion

        #region [5] 생상자: Constructors
        public Car()
        {
            this.name = "좋은차"; //기본값 초기화
        }
        // 생성자 : 시동, 필드초기화
        public Car(string name) => this.name = name;
        public Car(int length)
        {
            this.Name = "좋은차";
            _Length = length; //읽기전용 필드 초기화
            names = new string[length]; //넘겨온 값으로 요소생성
        }
        #endregion

        #region [6] 메서드: Public Methods
        //메서드: 기능/동작
        public void Run() => WriteLine($"{name}가 달린다");
        public void Left() => WriteLine($"{name}가 좌회전");
        public void Right() => WriteLine($"{name}가 우회전");
        #endregion

        #region [7] 속성: Public Properties
        //속성: private필드 -> 외부공개, 메서드에 괄호없음
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        #region [8] 소멸자: Destructor
        ~Car() //소멸자: 폐차, 만들어진 객체 소멸될 때
        {
            WriteLine($"{name}가 폐차됨");
        }
        #endregion

        #region [9] 인덱서: Indexor- 카탈로그
        public string this[int index]   //속성 배열로 관리
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        #endregion

        #region [10] 이터레이터: Iterators 반복기
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _Length; i++)
            {
                yield return names[i];
            }
        }
        #endregion

        #region [11] 대리자: Public Delegates
        public delegate void EventHandler(); //다중메서드 호출
        #endregion

        #region [12] 이벤트: public Events
        public event EventHandler Click; //이벤트
        #endregion

        #region [13] 이벤트 처리기: Event Handlers
        public void OnClick()
        {
            if (Click != null)
            {
                Click();
            }
        }
        #endregion


    }

    class CarRepair
    {
        //다형성(융통성): 다양한 형태
        //인터페이스형 인수: IS..을 상속받는 모든 클래스를 다 받을수잇음
        public CarRepair(IStandard car) => car.Run(); 
        //왜 Run 이외에는 안나올까
        public void CarRepair1(Car car) => WriteLine($"{car.Name}가 수리됨"); // Car 만 매개변수로 받음
    }
    class OOP_CarWorld
    {
        static void Main()
        {
            //[A] 클래스, 메서드, 생성자 테스트
            Car campingCar = new Car();
            campingCar.Run();

            //[B] 속성테스트
            Car sportsCar = new Car();
            sportsCar.Name = "스포츠카";
            sportsCar.Run();
            WriteLine(sportsCar.Name);

            //[C] 인덱서 테스트
            Car cars = new Car(2);
            cars[0] = "1번 자동차";
            cars[1] = "2번 자동차";
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    WriteLine(cars[i]);
            //} ???왜 안되지

            // [D] 이터레이터테스터
            foreach (string name in cars)
            {
                WriteLine(name);
            }

            // [E] 대리자, 이벤트, 이벤트 처리기 테스트
            Car btn = new Car("전기자동차");
            btn.Click += new Car.EventHandler(btn.Run);
            btn.Click += new Car.EventHandler(btn.Run);
            btn.OnClick();

            // [F] 다형성 테스트
            new CarRepair(campingCar);
            new CarRepair(sportsCar);
        }
    }
}
