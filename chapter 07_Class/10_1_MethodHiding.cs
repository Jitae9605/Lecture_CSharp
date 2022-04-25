using System;

namespace MethodHiding
{
    // 메소드를 숨김으로서 보안을 올릴수 있따
    // 단, 단순히 보이지 않게 숨기는 것이므로 형식에 맞으면 사용할수 있고 
    // 협업에서 이런일이 발생하면 원인을 찾기 매우 어려워진다.
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
