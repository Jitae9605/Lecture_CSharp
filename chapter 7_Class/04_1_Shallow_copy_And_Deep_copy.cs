using System;


namespace Shallow_copy_And_Deep_copy
{
    class MyClass
    {
        public int Myfield1;
        public int Myfield2;

        public MyClass DeepCopy()   // MyClass형을 반환
        {
            MyClass newCopy = new MyClass();    // 새로운 클래스(newCopy)를 만들어서 그 클래스에 현 클래스의 값들을 넣어준다.
            newCopy.Myfield1 = this.Myfield1;
            newCopy.Myfield2 = this.Myfield2;

            return newCopy;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass();
                source.Myfield1 = 10;
                source.Myfield2 = 20;

                MyClass target = source;    // 값을 복사한게 아니라 주소를 통해 연결한것(target이 source를 참조)
                target.Myfield2 = 30;       // 그래서 target의 값을 바꿨는데 source의 값도 바뀌는 것       

                Console.WriteLine($"{source.Myfield1} {source.Myfield2}");
                Console.WriteLine($"{target.Myfield1} {target.Myfield2}");
            }

            Console.WriteLine("\nDeep Copy");

            {
                MyClass source = new MyClass();
                source.Myfield1 = 10;
                source.Myfield2 = 20;

                MyClass target = source.DeepCopy(); // target이 DeepCopy함수로 만들어진 새로운 클래스(newCopy)와 연결(target이 newCopy를 참조)
                target.Myfield2 = 30;               // 그래서 target과 source는 전혀 다른 별개의 클래스가 된다.

                Console.WriteLine($"{source.Myfield1} {source.Myfield2}");
                Console.WriteLine($"{target.Myfield1} {target.Myfield2}");
            }
        }
    }


}

