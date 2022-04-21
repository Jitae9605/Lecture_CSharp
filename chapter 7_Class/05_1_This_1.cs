using System;

namespace This_1
{
    // this의 사용
    class Employee
    {
        private String Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;   // this.Name은 클래스멤버변수 private String Name을 의미
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string getPosition()
        {
            return this.Position;
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()} {pooh.getPosition()}");

            Employee trigger = new Employee();
            pooh.SetName("trigger");
            pooh.SetPosition("Cleaner");
            Console.WriteLine($"{pooh.GetName()} {pooh.getPosition()}");
        }


    }
}
