using System;

namespace Overriding
{
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
