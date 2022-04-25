using System;

namespace Make_Property
{
    // 프로퍼티를 직접만들고 써보자(get, set)
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get // 이름 반환
            {
                return name;
            }

            set // 이름 세팅
            {
                name = value;
            }
        }

        public DateTime Birthday
        {
            get // 생일반환
            {
                return birthday;
            }

            set // 생일세팅
            {
                birthday = value;
            }
        }

        public int Age  // 읽기전용 프로퍼티
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28); // 생일 세팅

            Console.WriteLine($"Name: {birth.Name}");
            Console.WriteLine($"Birthday: {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age: {birth.Age}");

        }
    }
}
