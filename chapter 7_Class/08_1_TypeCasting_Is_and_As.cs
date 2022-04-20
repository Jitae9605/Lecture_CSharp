using System;

namespace TypeCasting_Is_and_As
{
    // 형변환과 Is/As 연산자
    // is = 좌우 대상의 형을 검사하여 같으면 true 다르면 false를 반환
    // as = 좌측의 형을 우측의 형과 같게 만든다 단, 형변환에 실패하면 null을 반환한다. 
    // * 보통 as를 쓴다(is는 형변환이 우선되어야하는데 형변환에서 오류가 나면 종료되므로 안전성에서 as가 높다)
    class Mammal    // 포유류
    {
        public void Nurse()
        {
            Console.WriteLine("Nurese()");
        }

    }

    class Dog : Mammal  // 개 (포유류)
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal  // 고양이 (포유류)
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }

    class MainApp
    {
        static void Main(string[] agrs)
        {
            Mammal mammal1 = new Dog();     // 포유류1 = 개
            Dog dog;                        // dog = 개

            if (mammal1 is Dog)             // 포유류1이 개인지 판단
            {
                dog = (Dog)mammal1;         // 참이므로 안전하게 형변환 수행 및 dog에 대입
                dog.Bark();                 
            }

            Mammal mammal2 = new Cat();

            Cat cat1 = mammal2 as Cat;      // cat2에 Cat으로 형이 바뀐 mammal2을 대입
            if (cat1 != null)               // as는 형변환에 실패하면 null을 반환하므로 cat2가 null인지 검사하여 형변환 성공여부 판단.
                cat1.Meow();

            Cat cat2 = mammal1 as Cat;      // mammal1은 Dog이고 Dog과 Cat은 사이의 상속이 없으므로 형변환 불가능 ==> cat2 = null
            if (cat2 != null)           
                cat2.Meow();
            else                            // 건너뛰고 이리로온다.
                Console.WriteLine("cat2 is not a Cat");
        }
    }
}
