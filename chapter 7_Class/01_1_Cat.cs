using System;


namespace Lecture_CSharp.chapter_7_Class
{
    class _01_1_Cat
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
            _01_1_Cat kitty = new _01_1_Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            _01_1_Cat nero = new _01_1_Cat();

            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
