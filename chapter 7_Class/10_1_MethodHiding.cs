using System;

namespace MethodHiding
{
    class  Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod()");
        }
    }

    class Derived : Base
    {
        public new void MyMethod()
        {
            Console.WriteLine("Derived.MyMethod()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();

            Base baseOrDerived = new Derived();     // MethodHiding은 결국 안보이게 숨기는 것
            baseOrDerived.MyMethod();               // base의 함수가 출력됨
        }
    }
}
