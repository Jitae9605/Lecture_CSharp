using System;
/*문제 5.추상 클래스 활용 문제입니다.

- 현재 치즈크러스터 피자만 판매중이고, 향후에 새로운 피자를 판매할 계획임.
- 토핑은 치즈와 올리버만 가능하고, 향후에 새로운 토핑을 추가할 계획임.

- 피자 및 토핑 제품에서 관리하는 정보는 각각 제품명과 가격임.
- 피자를 선택하면 기본적으로 올리버 토핑이 추가가 되고,
 여러 토핑을 선택하는 경우, 반드시 마지막 토핑은 올리버가 되도록 함.

- 마지막으로 추가된 올리버 토핑의 주문 내역 및 가격 메소드를 각각 호출하면,
 전체 주문 상세 정보 및 계산 총액이 출력이 됨어야 함.

- 주문 예( 객체 생성 순서 )
  얇은 치즈크러스트 피자 선택 -> 치즈 토핑 선택 -> 치즈 토핑 선택 -> 
  올리버 토핑 선택 -> 올리버 토핑 선택

- 실행 결과( 상기의 주문 예 참고 )
  내역: 얇은 치즈크러스터 Pizza, 치즈, 치즈, 올리버, 올리버
 총액 : 32000원

 상기의 총액 결과는 아래 제품들의 가격 정보를 참고.

  얇은 치즈크러스트 Pizza : 25000
  올리버: 1500
  치즈: 2000*/




namespace MyAnser_Q5
{
    abstract class Pizza
    {
        public abstract void AddCheese();

        public abstract void AddOliver();

        public abstract void Print_bill();


    }

    class CheeseCrust : Pizza
    {
        private string Name;
        private int price;
        private string[] Toping = new string[10];
        private int number_of_toping;

        public CheeseCrust()
        {
            Name = "얇은 치즈크러스트 피자";
            price = 25000;
            number_of_toping = 0;
        }

        public override void AddCheese()
        {
            Toping[number_of_toping] = "치즈";
            price += 2000;
            number_of_toping++;
            Console.WriteLine("치즈추가");
        }

        public override void AddOliver()
        {
            Toping[number_of_toping] = "올리브";
            price += 1500;
            number_of_toping++;
            Console.WriteLine("올리브추가");
        }

        public override void Print_bill()
        {
            if((Toping[number_of_toping - 1] == "올리브" && number_of_toping > 1) || number_of_toping <= 1)
            {
                Console.WriteLine("\n< 주문정보 표시 > ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"피자 : {Name} \n가격 : {price}");
                Console.Write("추가한 토핑: ");
                for (int i = 0; i < number_of_toping; i++)
                {
                    if (i < number_of_toping - 1)
                    {
                        Console.Write($"{Toping[i]}, ");
                    }
                    else
                    {
                        Console.Write($"{Toping[i]}\n");
                        Console.WriteLine("--------------------------------\n");
                    }


                }
            }
            
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Pizza order1 = new CheeseCrust();
            order1.AddCheese();
            order1.AddCheese();
            order1.AddCheese();
            order1.AddOliver();
            order1.Print_bill();

            Pizza order2 = new CheeseCrust();
            order2.AddCheese();
            order2.Print_bill();
        }
    }


    
}
