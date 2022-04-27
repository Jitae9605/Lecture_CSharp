using System;

/*문제7 - 문제 4번의 확장, interface 를 사용한 다중 상속

- 외부 센서를 통해서 1시간 단위로 온도, 습도, 기압이 측정이 된다.
  단, 향후에는 다양한 센서를 추가 구성하여 공기의 질 데이터도 측정할 예정이다.

- 측정된 정보는 1 시간 단위로 2가지 이상의 Display 장치에 자동 출력이 된다.

- 현재의 Display 장치는 2대이고, 각각 현재 데이터를 출력해주는 Display 장치와
  1시간 전의 데이터를 출력해주는 Display 장치로 구성이 되어 있다.

- 앞으로 통계 정보를 출력해주는 Display 장치와
  공기의 질 데이터를 출력해주는 Display 장치가 추가 구성이 될 예정이다.
*/
namespace MyAnser_Q7
{
    interface IDisplay
    {
        void Print_curr_Info();
        void Update_Info(ref Sensor sensor);
        void Print_before_1hour_Info();
        // void Print_Cal_Info();
    }

    interface Isensor
    {
        void GetInfo(int temperature, int presure, int moisture);
    }

    class Sensor : Isensor
    {
        private int temperature;
        private int presure;
        private int moisture;

        public Sensor()
        {
            this.temperature = 0;
            this.presure = 0;
            this.moisture = 0;
        }


        public void GetInfo(int temperature, int presure, int moisture)
        {
            this.temperature = temperature;
            this.presure = presure;
            this.moisture = moisture;
        }

        public int GiveTemperature() { return temperature; }
        public int GivePresure() { return presure; }
        public int GiveMoisture() { return moisture; }
    }

    class Display : IDisplay
    {
        private int temperature;
        private int presure;
        private int moisture;
        private int P_temperature;
        private int P_presure;
        private int P_moisture;

        public Display(Sensor sensor)
        {
            temperature = sensor.GiveTemperature();
            presure = sensor.GivePresure();
            moisture = sensor.GiveMoisture();
            P_temperature = 0;
            P_presure = 0;
            P_moisture = 0;
        }

        public void Print_curr_Info()
        {
            Console.WriteLine("< 현재 대기상태 >");
            Console.WriteLine($"온도 : {temperature}");
            Console.WriteLine($"기압 : {presure}");
            Console.WriteLine($"습도 : {moisture}\n");
        }

        public void Print_before_1hour_Info()
        {
            Console.WriteLine("< 1시간전 대기상태 >");
            Console.WriteLine($"온도 : {P_temperature}");
            Console.WriteLine($"기압 : {P_presure}");
            Console.WriteLine($"습도 : {P_moisture}\n");
        }

        public void Update_Info(ref Sensor sensor)
        {
            // 실제 센서가 업으니 정보 업데이트는 그냥 +1로 한다.
            P_temperature = temperature;
            P_presure = presure;
            P_moisture = moisture;
            temperature = sensor.GiveTemperature();
            presure = sensor.GivePresure();
            moisture = sensor.GiveMoisture();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Sensor sensor = new Sensor();

            Display curr_display = new Display(sensor);
            Display pre_display = new Display(sensor);

            curr_display.Print_curr_Info();
            pre_display.Print_before_1hour_Info();


            sensor.GetInfo(1, 10, 100);
            curr_display.Update_Info(ref sensor);
            pre_display.Update_Info(ref sensor);
            curr_display.Print_curr_Info();
            pre_display.Print_before_1hour_Info();

            sensor.GetInfo(2, 20, 200);
            curr_display.Update_Info(ref sensor);
            pre_display.Update_Info(ref sensor);
            curr_display.Print_curr_Info();
            pre_display.Print_before_1hour_Info();

            sensor.GetInfo(3, 30, 300);
            curr_display.Update_Info(ref sensor);
            pre_display.Update_Info(ref sensor);
            curr_display.Print_curr_Info();
            pre_display.Print_before_1hour_Info();



        }
    }

}
