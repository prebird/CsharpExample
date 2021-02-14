using System;
using static System.Console;
using System.Collections.Generic;

// [2] 컬렉션 이니셜라이저를 이용한 여러 개체 초기화
class Person
{
    public string Name { get; set; }
}

// [3] 리스트 안에 표 형태로 담기( 모델클래스?)
class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}

// [4]  T를 매개변수로 받아서 형식을 자유로이 하기
class Cup<T>
{
    public T Content { get; set; }
}
class Person1
{
    public string Name { get; set; }
    public int Age { get; set; }
}

// [5] 형식 매개변수 2개 사용
class Pair<T, V>
{
    public T First { get; set; }
    public V Second { get; set; }
    public Pair(T first, V second) //생성자
    {
        First = first;
        Second = second;
    }
}

class GenericType
{
    static void Main()
    {
        // [1] List<T> 기본모양
        List<string> colors = new List<string> { "Red", "Blue" };
        foreach (string color in colors) { WriteLine(color); }

        // [2] 컬렉션 이니셜라이저를 이용한 여러 개체 초기화
        List<Person> people = new List<Person>
        {
            new Person {Name = "홍길동"},
            new Person {Name = "백두산"},
            new Person {Name = "임꺽정"}
        };
        foreach (Person person in people)
        {
            WriteLine(person.Name);
        }

        // [3] 리스트 안에 표 형태로 담기( 모델클래스?)
        List<Category> categories = new List<Category>
        {
            new Category {CategoryId=1, CategoryName="좋은책"},
            new Category {CategoryId=2, CategoryName ="좋은강의"},
            new Category {CategoryId=3, CategoryName="좋은 컴퓨터"}
        };
        foreach (Category category in categories)
        {
            WriteLine($"아이디: {category.CategoryId}, 이름: {category.CategoryName}");
        }

        // [4]  T를 매개변수로 받아서 형식을 자유로이 하기
        var text = new Cup<string>();
        text.Content = "STRING";

        var number = new Cup<int>();
        number.Content = 1_234;

        var person1 = new Cup<Person1>();
        person1.Content = new Person1 { Name = "Hong", Age = 21 };

        // [5] 형식 매개변수 2개 사용
        var my = new Pair<string, bool>("나는멋져", true); //대괄호x 괄호o
        var tuple = new Pair<int, double>(1234, 3.13);


    }
}