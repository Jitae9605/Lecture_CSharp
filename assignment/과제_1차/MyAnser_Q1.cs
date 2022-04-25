using System;


/*TV, Computer, Audio 제품의 정보는
제품 가격과 제품 구매시 제공하는 보너스 포인트 로 구성이 됩니다.

   그리고, 상기의 3 가지 제품을 구매하는 구매자가 있고,
   구매자는 소유 금액, 보너스 점수, 구매 목록 정보로 구성이 됩니다.
  구매자의 기능은 다음과 같습니다.
  - 제품 구매시 포인트 적립이 가능해야 합니다.
  - 제품 구입시 잔액을 확인 후 구매합니다.
  - 현재 구입한 제품의 목록과 총 구매 금액을 출력할 수 있습니다.

  마지막으로 한 명의 구매자가 제품을 구입한 후의 정보를 테스트 할 수 있는
  main 함수를 작성하세요.


실행 예)

Tv를 구입하셨습니다.
Computer를 구입하셨습니다.
Audio를 구입하셨습니다.
구입하신 물품의 총금액은 350만원입니다.
구입하신 제품은 Tv, Computer, Audio, 입니다.*/

namespace Anser
{
    class TV         // TV
    {
        private int price;  // 가격
        private int bonus;  // 보너스

        // 생성자
        public TV(int aprice, int abonus)
        {
            price = aprice;
            bonus = abonus;
        }


        public int GetPrice()
        {
            return price;
        }

        public int GetBonus()
        {
            return bonus;
        }
    }

    class Computer      // 컴퓨터
    {
        private int price;  // 가격
        private int bonus;  // 보너스

        // 생성자
        public Computer(int aprice, int abonus)
        {
            price = aprice;
            bonus = abonus;
        }

        public int GetPrice()
        {
            return price;
        }

        public int GetBonus()
        {
            return bonus;
        }
    }


    class Audio     // 오디오
    {
        private int price;  // 가격
        private int bonus;  // 보너스

        // 생성자
        public Audio(int aprice, int abonus)
        {
            price = aprice;
            bonus = abonus;
        }

        public int GetPrice()
        {
            return price;
        }

        public int GetBonus()
        {
            return bonus;
        }
    }
       
    class buyer // 구매자
    { 
        private int money;
        private int mybonus;
        private int buy_TV_num;
        private int buy_Computer_num;
        private int buy_Audio_num;

        // 생성자
        public buyer(int amoney)
        {
            money = amoney;
            mybonus = 0;
            buy_TV_num = 0;
            buy_Computer_num = 0;
            buy_Audio_num = 0;
        }

        // money
        public void SetMoney(int amoney)
        {
            money = amoney;
        }

        public int GetMoney()
        {
            return money;
        }

        // bonus
        public void SetBonus(int abonus)
        {
            mybonus = abonus;
        }

        public int Getbonus()
        {
            return mybonus;
        }

        // TV
        public void SetTV_num(int anum)
        {
            buy_TV_num = anum;
        }

        public int GetTV_num()
        {
            return buy_TV_num;
        }

        public void buyTV(int num, int price, int abonus)
        {
            if (money < price * num)
            {
                Console.WriteLine("금액이 부족합니다.");
            }
            else
            {
                SetMoney(GetMoney() - (price * num));
                SetBonus(Getbonus() + (abonus * num));
                SetTV_num(GetTV_num() + num);
                Console.WriteLine($"{num}개의 TV를 샀습니다.");
                Console.WriteLine($"남은 금액은 {money}입니다.");
                Console.WriteLine($"현재까지의 보너스는 {mybonus}입니다.\n");
                

            }
        }

        // Computer
        public void SetComputer_num(int anum)
        {
            buy_Computer_num = anum;
        }

        public int GetComputer_num()
        {
            return buy_Computer_num;
        }

        public void buyComputer(int num, int price, int abonus)
        {
            if (money < price * num)
            {
                Console.WriteLine("금액이 부족합니다.");
            }
            else
            {
                SetMoney(GetMoney() - (price * num));
                SetBonus(Getbonus() + (abonus * num));
                SetComputer_num(GetComputer_num() + num);
                Console.WriteLine($"{num}개의 Computer를 샀습니다.");
                Console.WriteLine($"남은 금액은 {money}입니다.");
                Console.WriteLine($"현재까지의 보너스는 {mybonus}입니다.\n");
               

            }
        }

        // Audio
        public void SetAudio_num(int anum)
        {
            buy_Audio_num = anum;
        }

        public int GetAudio_num()
        {
            return buy_Audio_num;
        }

        public void buyAudio(int num, int price, int abonus)
        {
            if (money < price * num)
            {
                Console.WriteLine("금액이 부족합니다.");
            }
            else
            {
                SetMoney(GetMoney() - (price * num));
                SetBonus(Getbonus() + (abonus*num));
                SetAudio_num(GetAudio_num() + num);
                Console.WriteLine($"{num}개의 Audio를 샀습니다.");
                Console.WriteLine($"남은 금액은 {money}입니다.");
                Console.WriteLine($"현재까지의 보너스는 {mybonus}입니다.\n");
                
            }
        }

        // 현재까지 구매자가 구매한 구매리스트 출력
        public void PrintList()
        {
            Console.WriteLine("\n < 현재까지 구매한 물품리스트 >");
            Console.WriteLine($"TV : {buy_TV_num,8}");
            Console.WriteLine($"Computer : {buy_Computer_num}");
            Console.WriteLine($"Audio : {buy_Audio_num,4}");

        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            // 상품 객체들 생성(가격, 보너스 지정)
            TV product_tv = new TV(1000, 1000);
            Computer product_Computer = new Computer(100, 100);
            Audio product_Audio = new Audio(10, 10);

            // 구매자 객체 생성(소지금 지정)
            buyer customer = new buyer(50000);

            // TV 5개 구매
            customer.buyTV(5, product_tv.GetPrice(), product_tv.GetBonus());

            // 컴퓨터 5개 구매
            customer.buyComputer(5, product_Computer.GetPrice(), product_Computer.GetBonus());

            // 오디오 5개 구매
            customer.buyAudio(5, product_Audio.GetPrice(), product_Audio.GetBonus());

            // TV 10개 구매
            customer.buyTV(10, product_tv.GetPrice(), product_tv.GetBonus());

            // TV 1000개 구매 - 돈없어서 결재안됨
            customer.buyTV(1000, product_tv.GetPrice(), product_tv.GetBonus());

            customer.PrintList();

        }
    }
}
