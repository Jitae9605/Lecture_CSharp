using System;

namespace MyAnser_Q3
{
    // 스타크래프트 건물 띄우고 움직이고 내려앉는 매커니즘
    interface Ibuliding
    {

    }

    interface Icanfly
    {
        void fly();
        void moving();
        void landing();
        void stop();

        void print_state();
    }

    class academy : Ibuliding
    {
        private int Max_HP;
        private int curr_HP;

        public academy(int amax, int acurr)
        {
            Max_HP = amax;
            curr_HP = acurr;
        }
        
    }

    class Bunker : Ibuliding
    {
        private int Max_HP;
        private int curr_HP;

        public Bunker(int amax, int acurr)
        {
            Max_HP = amax;
            curr_HP = acurr;
        }

    }

    class Factory : Ibuliding, Icanfly
    {
        private int Max_HP;
        private int curr_HP;
        private int state;

        public Factory(int amax, int acurr)
        {
            Max_HP = amax;
            curr_HP = acurr;
            state = 0;
        }

        public void fly()
        {
            if (state == 0)
            {
                state = 1;
                Console.WriteLine("이제 떠있음.");

            }

            else
                Console.WriteLine("이미 떠있음.");

        }

        public void moving()
        {
            if (state == 1)
            {
                state = 2;
                Console.WriteLine("움직이는 중.");

            }

            else if (state == 0)
                Console.WriteLine("떠있어야 움직일수 있음");
            else if (state == 2)
                Console.WriteLine("이미 움직이는 중");
            else
                Console.WriteLine("뭔가 잘못됨");


        }

        public void landing()
        {
            if (state == 1)
            {
                state = 0;
                Console.WriteLine("착륙완료");
            }

            else if (state == 0)
                Console.WriteLine("이미 착륙함");
            else if (state == 2)
                Console.WriteLine("멈춰야 착륙가능");
            else
                Console.WriteLine("뭔가 잘못됨");
        }

        public void stop()
        {
            if (state == 2)
            {
                state = 0;
                Console.WriteLine("멈춤");
            }

            else if (state == 0)
                Console.WriteLine("착륙된 상태로 이미 멈춰있음");
            else if (state == 1)
                Console.WriteLine("떠있는 상태로 이미 멈춰있음");
            else
                Console.WriteLine("뭔가 잘못됨");
        }

        public void print_state()
        {
            Console.WriteLine("\n현재 건물의 상태는 ");
            switch(state)
            {
                case 0:
                    Console.WriteLine("착륙한 상태");
                    break;
                case 1:
                    Console.WriteLine("떠있음 + 정지");
                    break;
                case 2:
                    Console.WriteLine("떠있음 + 움직임");
                    break;
                default:
                    Console.WriteLine("뭔가 잘못됨");
                    break;
            }
                
        }
    }

    class Barruck : Ibuliding, Icanfly
    {
        private int Max_HP;
        private int curr_HP;
        private int state;  // 0 = landing상태 , 1 = 떠오른상태(stop상태), 2 = 움직임(moving)

        public Barruck(int amax, int acurr)
        {
            Max_HP = amax;
            curr_HP = acurr;
            state = 0;
        }

        public void fly()
        {
            if (state == 0)
            {
                state = 1;
                Console.WriteLine("이제 떠있음.");

            }

            else
                Console.WriteLine("이미 떠있음.");
                
        }

        public void moving()
        {
            if (state == 1)
            {
                state = 2;
                Console.WriteLine("움직이는 중.");

            }

            else if (state == 0)
                Console.WriteLine("떠있어야 움직일수 있음");
            else if (state == 2)
                Console.WriteLine("이미 움직이는 중");
            else
                Console.WriteLine("뭔가 잘못됨");


        }

        public void landing()
        {
            if (state == 1)
            {
                state = 0;
                Console.WriteLine("착륙완료");
            }

            else if (state == 0)
                Console.WriteLine("이미 착륙함");
            else if (state == 2)
                Console.WriteLine("멈춰야 착륙가능");
            else
                Console.WriteLine("뭔가 잘못됨");
        }

        public void stop()
        {
            if (state == 2)
            {
                state = 1;
                Console.WriteLine("멈춤");
            }

            else if (state == 0)
                Console.WriteLine("착륙된 상태로 이미 멈춰있음");
            else if (state == 1)
                Console.WriteLine("떠있는 상태로 이미 멈춰있음");
            else
                Console.WriteLine("뭔가 잘못됨");
        }

        public void print_state()
        {
            Console.WriteLine("\n현재 건물의 상태는 ");
            switch (state)
            {
                case 0:
                    Console.WriteLine("착륙한 상태");
                    break;
                case 1:
                    Console.WriteLine("떠있음 + 정지");
                    break;
                case 2:
                    Console.WriteLine("떠있음 + 움직임");
                    break;
                default:
                    Console.WriteLine("뭔가 잘못됨");
                    break;
            }

        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            academy a = new academy(100, 100);
            Barruck b = new Barruck(100, 100);
            Bunker c = new Bunker(100, 100);
            Factory d = new Factory(100, 100);

            b.fly();
            b.moving();
            b.stop();
            b.landing();
            b.print_state();


            Console.WriteLine();
            d.landing();


        }
    }


}
