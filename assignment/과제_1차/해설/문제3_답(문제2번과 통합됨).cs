using System;
using System.Collections;

namespace Ex3ForClass
{
    interface IRepairable       // 수리가능(기계유닛)
    { }

    interface ILiftable         // 날수있음(특정 건물)
    {
        public void liftOff();          // 난다
        public void move(int x, int y); // 이동
        public void stop();             // 멈춘다
        public void land();             // 착륙한다
    }

    class ILiftableImpl : ILiftable     // 날수있는 건물의 각 메소드별 동작 설정
    {
        public void land()
        {
            Console.WriteLine("건물을 지상에 내립니다.");
        }

        public void liftOff()
        {
            Console.WriteLine("건물을 공중으로 올립니다.");
        }

        public void move(int x, int y)
        {
            Console.WriteLine($"건물을 좌표(X : {x}, Y : {y})로 이동합니다.");
        }

        public void stop()
        {
            Console.WriteLine("건물의 이동을 멈춥니다.");
        }
    }

    class Unit                          // 유닛 클래스
    {
        private int hitPoint;           // 현재체력
        private int maxHitPoint;        // 최대체력

        public Unit(int hitPoint)       // 유닛생성자
        {
            this.hitPoint = hitPoint;
            this.maxHitPoint = 200;
        }

        public int getHitPoint()
        {
            return this.hitPoint;
        }

        public void setHitPoint(int hitPoint)
        {
            this.hitPoint = hitPoint;
        }

        public int getMaxHitPoint()
        {
            return this.maxHitPoint;
        }
    }

    class GroundUnit : Unit				// 지상 유닛 : 유닛
    {
        public GroundUnit(int hitPoint) : base(hitPoint)
        {
            //Console.WriteLine("GroundUnit() 생성자 호출됨.");
        }
    }

    class AirUnit : Unit
    {
        public AirUnit(int hitPoint) : base(hitPoint)
        {
            //Console.WriteLine("AirUnit() 생성자 호출됨.");
        }
    }

    class GroundBuilding : Unit
    {
        public GroundBuilding(int hitPoint) : base(hitPoint)
        {
            //Console.WriteLine("GroundBuilding() 생성자 호출됨.");
        }
    }

    class AirBuilding : Unit
    {
        public AirBuilding(int hitPoint) : base(hitPoint)
        {
            //Console.WriteLine("AirBuilding() 생성자 호출됨.");
        }
    }

    class Tank : GroundUnit, IRepairable
    {
        public Tank(int hitPoint) : base(hitPoint)
        {
            //Console.WriteLine("GroundUnit() 생성자 호출됨.");
        }
    }

    class Dropship : AirUnit, IRepairable
    {
        public Dropship(int hitPoint) : base(hitPoint)
        {
            //Console.WriteLine("GroundUnit() 생성자 호출됨.");
        }
    }

    class Marine : GroundUnit
    {
        public Marine(int hitPoint) : base(hitPoint)
        {
            //Console.WriteLine("GroundUnit() 생성자 호출됨.");
        }
    }

    class SCV : GroundUnit, IRepairable
    {
        public SCV(int hitPoint) : base(hitPoint)
        {
            //Console.WriteLine("GroundUnit() 생성자 호출됨.");
        }

        public void repair(IRepairable repairableUnit)
        {
            if (repairableUnit is Marine)
            {
                Console.WriteLine("수리할 수 없는 Unit 입니다.");
            }
            else
            {
                Unit u = (Unit)repairableUnit;
                int hitPoint = u.getHitPoint();
                while (u.getHitPoint() != u.getMaxHitPoint())
                {
                    /* Unit의 HP를 증가시킨다. */
                    u.setHitPoint(hitPoint++);
                }
                Console.WriteLine("수리가 끝났습니다.");
            }
        }
    }

    class Bunker : GroundBuilding
    {
       
        public Bunker(int hitPoint) : base(hitPoint)
        {
            Console.WriteLine("Bunker() 생성자 호출됨.");
        }

    }

    class Barrack : AirBuilding, ILiftable
    {
        ILiftableImpl liftImpl = new ILiftableImpl();

        public Barrack(int hitPoint) : base(hitPoint)
        {
            Console.WriteLine("Barrack() 생성자 호출됨.");
        }

        public void land()
        {
            this.liftImpl.land();
        }

        public void liftOff()
        {
            this.liftImpl.liftOff();
        }

        public void move(int x, int y)
        {
            this.liftImpl.move(x, y);
        }

        public void stop()
        {
            this.liftImpl.stop();
        }
    }



    class MainApp
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank(100);
            Dropship dropship = new Dropship(100);

            Marine marine = new Marine(100);
            SCV scv = new SCV(100);

            scv.repair(tank);
            scv.repair(dropship);
            //scv.repair(marine);

            Console.WriteLine();

            Barrack barrack = new Barrack(200);
            barrack.liftOff();
            barrack.move(20, 60);
            barrack.stop();
            barrack.land();

            Console.WriteLine();

            Bunker bunker = new Bunker(100);
            
        }
    }
}
