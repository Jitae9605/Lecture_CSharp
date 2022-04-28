using System;
namespace NET402

{

    class Ex12_Input

    {

        public static void Main(string[] args)

        { 
            //유저가 프로그램을 통해 데이터 입력(키보드) //
            // Console.Read(); 
            // Console.ReadLine();
            // 사용자로부터 문자를 입력받아 그대로 출력하시오.

            Console.Write("문자 입력 : ");
            int code = Console.Read();
            Console.WriteLine("입력된 문자는 {0}입니다.", code);
            Console.WriteLine("입력된 문자는 {0}입니다.", (char)code);

            
                    
            Console.Write("문자열 입력 : ");
            string codeline = Console.ReadLine(); 
            Console.WriteLine("입력된 문자열은 {0}입니다.", codeline);


        }

    }

}