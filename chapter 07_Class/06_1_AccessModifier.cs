using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    // 접근한정자
    // public : 클래스 내/외부 모든곳
    // protected : 클래스 내부접근 가능, 외부접근 불가 (단, 파생클래스에서는 접근 가능)
    // private : 오직 클래스 내부접근 가능
    // internal : 같은 어셈블리에 있는 코드에서만 public수준 접근.(다른 어셈블리에서의 접근은 private수준)  
    // protected internal : 같은 어셈블리에 있는 코드에서만 protected수준 접근.(다른 어셈블리에서의 접근은 private수준)  
    // private protected : 같은 어셈블리에 있는 클래스에서 상속받은 클래스 내부에서만 접근이 가능


    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temperature)     // temperature가 protected이므로 클래스 내부에서 접근
        {
            if (temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of tempperature range");
            }

            this.temperature = temperature;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine($"Trun on water : {temperature}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);  
                heater.TurnOnWater();       // Exception이 발생했으므로 바로 catch문으로 간다.

                heater.SetTemperature(50);
                heater.TurnOnWater();

            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message); // Message = "Out of tempperature range"
            }
        }
    }
}
