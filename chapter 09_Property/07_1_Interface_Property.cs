using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Property
{
    // 인터페이스에 프로퍼티를 등록할수 있다.
    interface INamedValue
    {
        string Name { get; set; }
        string Value { get; set; }
    }

    class NamedValue :INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue() { Name = "이름", Value = "박상현" };
            NamedValue height = new NamedValue() { Name = "키", Value = "177cm" };
            NamedValue weight = new NamedValue() { Name = "몸무게", Value = "90kg" };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");
        }
    }
}
