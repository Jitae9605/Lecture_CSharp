using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyFields
{
    class Configuration
    {
        private readonly int min; // readonly로 선언 = 생성자에서 처음 생성될때 값 지정. 이후로는 값 변경이 불가능
        private readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1;
            max = v2;
        }

        public void ChangeMax(int newMax)
        {
            // max = newMax;    에러발생함                   

        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Configuration c = new Configuration(100, 10);
        }
    }


}
