using System;


namespace This_2
{
    class ThisConstructor
    {
        class MyClass
        {
            int a, b, c;

            public MyClass()
            {
                this.a = 5425;
                Console.WriteLine("MyClass()");
            }

            public MyClass(int b) : this()              //  여기서 this() == MyClass() == (this.a = 5425)
            {
                this.b = b;                            
                Console.WriteLine($"MyClass(b)");
            }

            public MyClass(int b, int c) : this(b)      //  여기서 this(b) == MyClass(b) == (this.a = 5425, this.b = b)
            {
                this.c = c;
                Console.WriteLine($"MyClass({b},{c})");
            }

            public void PrintFields()
            {
                Console.WriteLine($"a:{a}, b:{b}, c:{c}");
            }

        }

        class MainApp
        {
            static void Main(string[] args)
            {
                MyClass a = new MyClass(); // a = 5425
                a.PrintFields();
                Console.WriteLine();

                MyClass b = new MyClass(1); // a = 5425, b = 1
                b.PrintFields();
                Console.WriteLine();

                MyClass c = new MyClass(10,20); // a = 5425, b = 10, c = 20
                c.PrintFields(); 
            }
        }
    }
}
