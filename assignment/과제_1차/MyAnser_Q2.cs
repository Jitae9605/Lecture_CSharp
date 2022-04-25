using System;
/*
 스타크래프트 유닛과 SCV를 통한 기계유닛 수리기능을 구현 
*/

namespace MyAnser_Q2
{
    interface Iunit
    {
        int Getmax_HP();
        int Getcurr_HP();

    }

    interface Iground_unit 
    {
        void run();
    }

    interface Iair_unit 
    {
        void fly();
    }

    interface Imachine 
    {
        void repairbySCV();
    }

    interface IRepairman
    {
        void repairing(Imachine a);
    }



    class Marine : Iunit, Iground_unit
    {
        private int max_HP;
        private int curr_HP;
        
        public Marine(int amax, int acurr)
        {
            max_HP = amax;
            curr_HP = acurr;
        }

        public int Getmax_HP()
        {
            return max_HP;
        }


        public int Getcurr_HP()
        {
            return curr_HP;
        }

        public void run()
        {
            Console.WriteLine("I'm Ground Unit!");
        }
    }

    class SCV : Iunit, Iground_unit, IRepairman
    {
        private int max_HP;
        private int curr_HP;

        public SCV(int amax, int acurr)
        {
            max_HP = amax;
            curr_HP = acurr;
        }

        public int Getmax_HP()
        {
            return max_HP;
        }


        public int Getcurr_HP()
        {
            return curr_HP;
        }

        public void run()
        {
            Console.WriteLine("I'm Ground Unit!");
        }

        public void repairing(Imachine a)
        {
            Console.WriteLine("SCV : 수리하러 가는 중");
            a.repairbySCV();
            Console.WriteLine("SCV : 수리 끝!");

        }
    }

    class Tank : Iunit, Iground_unit, Imachine
    {
        private int max_HP;
        private int curr_HP;

        public Tank(int amax, int acurr)
        {
            max_HP = amax;
            curr_HP = acurr;
        }

        public int Getmax_HP()
        {
            return max_HP;
        }

        public int Getcurr_HP()
        {
            return curr_HP;
        }

        public void run()
        {
            Console.WriteLine("I'm Ground Unit!");
        }

        public void repairbySCV()
        {
            Console.WriteLine("상태 : 탱크 수리 중");
            curr_HP = max_HP;
            Console.WriteLine("상태 : 탱크 수리완료");
        }
    }

    class DropShip : Iunit, Iair_unit, Imachine
    {
        private int max_HP;
        private int curr_HP;

        public DropShip(int amax, int acurr)
        {
            max_HP = amax;
            curr_HP = acurr;
        }

        public int Getmax_HP()
        {
            return max_HP;
        }


        public int Getcurr_HP()
        {
            return curr_HP;
        }

        public void fly()
        {
            Console.WriteLine("I'm Flying Unit!");
        }

        public void repairbySCV()
        {

            Console.WriteLine("상태 : 드랍쉽 수리 중");
            curr_HP = max_HP;
            Console.WriteLine("상태 : 드랍쉽 수리완료");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Marine marine = new Marine(50,50);
            SCV scv = new SCV(60, 60);
            Tank tank = new Tank(150, 80);
            DropShip dropShip = new DropShip(150, 100);

            // 탱크수리
            Console.WriteLine($"{tank.Getcurr_HP()}");
            scv.repairing(tank);
            Console.WriteLine($"{tank.Getcurr_HP()}");

            // 드랍쉽 수리
            Console.WriteLine($"\n{dropShip.Getcurr_HP()}");
            scv.repairing(dropShip);
            Console.WriteLine($"{dropShip.Getcurr_HP()}");

            /*
            // 마린 수리 - 오류발생 = Marine은 Imachine이 아니므로
            Console.WriteLine($"\n{marine.Getcurr_HP()}");
            scv.repairing(marine);  
            Console.WriteLine($"{marine.Getcurr_HP()}");
            */
        }
    }

   
}
