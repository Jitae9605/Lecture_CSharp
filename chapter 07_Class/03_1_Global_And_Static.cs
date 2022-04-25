using System;

namespace Global_and_Static
{
    // Global과 Static 사이의 차이점
    class Global
    {
        public static int count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.count++;
        }
    }

    class mainapp
    {
        static void Main()
        {
            Console.WriteLine($"Global.count : {Global.count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine($"Global.count : {Global.count}");

        }
    }

}