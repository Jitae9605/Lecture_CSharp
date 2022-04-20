using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // 상속과 protected의 사용
    class Base
    {
        protected string Name;          // protected는 클래스 내부와 파생클래스에서의 접근을 허용

        public Base(string Name)        // 클래스 내부에서의 Name접근
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }

        ~Base()
        {
            Console.WriteLine($"{this.Name}.~Base()");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"{Name}.BaseMethod()");
        }
    }

    class Derived : Base
    {
        public Derived(string Name) : base(Name)        // 파생클래스(자식클래스)에서의 Name(부모클래스의 protected 멤버변수)접근
        {
            Console.WriteLine($"{this.Name}.Derived()");
        }

        ~Derived()
        {
            Console.WriteLine($"{this.Name}.~Derived()");
        }

        public void DerivedMethod()
        {
            Console.WriteLine($"{Name}.DerivedMethod()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");         // Base.Name에 a를 입력
            a.BaseMethod();
            Console.WriteLine();

            Derived b = new Derived("b");   // Base.Name에 b를 입력(파생클래스로부터의 접근)
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
