using System;

/*문제 6.상속 및 객체 생성 분리 관련 문제입니다.

- 피자 주문은 피자 가게 주문 함수를 통해서 하고,
 이때, 주문과 동시에 피자 조리 전체가 진행이 되고,
 포장까지 진행이 됨.
- 주문 가능한 피자 종류는 치즈 피자, 페퍼로니 피자, 야채 피자임.
- 피자 관리 정보는 피자명, 도우, 소스, 토핑 임.
- 피자 조리 과정(메소드)은 재료 준비, 굽기, 자르기, 포장 임.

- 피자 객체의 생성은 피자 가게와 별도의 클래스에서
  생성될 수 있도록 하여, 피자 객체 생성을 분리하도록 함.

- 테스트를 할 수 있는 main() 함수가 있는 class 를 작성.*/

namespace MyAnser_Q6
{
    class PizzaStore
    {
        public Pizza Pizzaorder(int aName, int adow, int asouce, params int[] aToping)
        {
            string Name = "null";
            string dow = "null";
            string souce = "null";
            string[] Toping = new string[10];

            switch (aName)
            {
                case 1:
                    Name = "치즈 피자";
                    break;
                case 2:
                    Name = "페퍼로니 피자";
                    break;
                case 3:
                    Name = "야채 피자";
                    break;
            }

            switch (adow)
            {
                case 1:
                    dow = "쌀 도우";
                    break;
                case 2:
                    dow = "밀 도우";
                    break;
                case 3:
                    dow = "플랫 도우";
                    break;
            }

            switch (asouce)
            {
                case 1:
                    souce = "토마토 소스";
                    break;
                case 2:
                    souce = "바베큐 소스";
                    break;
                case 3:
                    souce = "스모키 소스";
                    break;
            }

            Array.Resize<string>(ref Toping, aToping.Length);

            for (int i = 0; i < aToping.Length; i++)
            {
                switch (aToping[i])
                {
                    case 1:
                        Toping[i] = "올리브";
                        break;
                    case 2:
                        Toping[i] = "치즈";
                        break;
                    case 3:
                        Toping[i] = "페퍼로니";
                        break;
                }
            }

            

            Pizza newpizza = new Pizza(Name, dow, souce, Toping);



            return newpizza;
        }
    }

    class Pizza : PizzaStore
    {
        private string Name;
        private string dow;
        private string souce;
        private string[] Toping = new string[10];

        public Pizza (string aName,string adow, string asouce, params string[] aToping)
        {
            Name = aName;
            dow = adow;
            souce = asouce;
            for (int i = 0; i < aToping.Length; i++) 
            {
                Toping[i] = aToping[i];
            }

            Array.Resize<string>(ref Toping, aToping.Length);
            Console.WriteLine("주문완료!\n");

            Console.WriteLine("조리 시작!\n");
            setting();
            bake();
            slice();
            pakcing();
            Console.WriteLine("조리 완료!");


        }

        public void print_order()
        {
            Console.WriteLine("\n< 주문 영수증 >\n");
            Console.WriteLine("===========================");
            Console.WriteLine($"피자 : {Name}");
            Console.WriteLine($"도우 : {dow}");
            Console.WriteLine($"소스 : {souce}");
            for (int i = 0; i < Toping.Length; i++)
            {
                Console.WriteLine($"추가 {i+1} : {Toping[i]}");
            };
            Console.WriteLine("===========================\n");

        }

        public void setting()
        {
            Console.WriteLine("재료세팅중...");
            Console.WriteLine("완료\n");
        }
        public void bake()
        {
            Console.WriteLine("굽는 중...");
            Console.WriteLine("완료\n");
        }

        public void slice()
        {
            Console.WriteLine("자르는 중...");
            Console.WriteLine("완료\n");
        }

        public void pakcing()
        {
            Console.WriteLine("포장중...");
            Console.WriteLine("완료\n");
        }

    }



    class MainApp
    {
        static void Main(string[] args)
        {
            PizzaStore store = new PizzaStore();
            
            Pizza order1 = store.Pizzaorder(1, 2, 1, 1,1,2,1,2,1,3);
            order1.print_order();
        }
    }
}
