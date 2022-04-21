using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    // 구조체의 생성 및 사용
    struct Point3D
    {
        public int X;
        public int Y;
        public int Z;

        public Point3D(int X, int Y, int Z) // 생성자
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
            return string.Format($"{X}, {Y}, {Z}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Point3D p3d1;   // 선언만으로 인스턴스가 생성됨
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;

            Console.WriteLine(p3d1.ToString());

            Point3D p3d2 = new Point3D(100, 200, 300);  // new를 이용하여 생성하는것도 가능
            Point3D p3d3 = p3d2;                        // 이렇게만 해도 깊은 복사가 일어난다(클래스와 달리 참조의 개념이 아닌 값을 복사해 집어넣기 때문)
            p3d3.Z = 400;                               // 별개의 존재가 되어 이렇게 해도 p3d2의 값은 영향이 없다.

            Console.WriteLine(p3d2.ToString());
            Console.WriteLine(p3d3.ToString());

        }
    }
}
