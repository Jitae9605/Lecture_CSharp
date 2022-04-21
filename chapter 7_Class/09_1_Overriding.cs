using System;

namespace Overriding
{
    // 오버라이딩을 통한 함수 재사용성증가
    // 부모에서 virtual을, 자식에서 샅은이름에 override를 선언한후 내부에 덮어쓸 내용을 입력 ('base.함수이름()'을 통해 기능 덧붙이기가 가능)
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("  - Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("  - Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("  - Double-Barrel Cannons Armed");
            Console.WriteLine("  - Micro-Rokect Launcher Armed");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" < Creatring ArmorSuite... >");
            ArmorSuite armorSuite = new ArmorSuite();
            armorSuite.Initialize();

            Console.WriteLine("\n < Creatring ArmorSuite... >");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize();

            Console.WriteLine("\n < Creatring ArmorSuite... >");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();


        }
    }

}
