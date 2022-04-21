using System;


namespace Cat
{   
    // C# 에서의 클래스 선언 및 생성과 그 사용방법 그리고 출력방법
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    class mainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();      // Cat클래스를 가지는 kitty객체 생성
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}"); // $는 이후의 {}내부는 멤버변수의 값을 개입해서 넣는다는 것을 의미

            Cat nero = new Cat();

            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
