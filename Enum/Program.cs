using System;

// 하나의 이름으로 서로 관련있는 정수값을 가지는 상수 집합을 정의
namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal a = Animal.cats;
            Console.WriteLine(a);

            Animal b = Animal.dogs;
            Console.WriteLine(b);
            
            Console.WriteLine(nameof(Animal.Mouse));
        }

        enum Animal
        {
            Mouse,
            Tiger,
            cats,
            dogs
        }
    }
}