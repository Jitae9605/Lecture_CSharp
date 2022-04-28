using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraint_Generalization
{
	// 타입 일반화를 제약한다(정수/실수만 들어가는곳에 string을 잘못넣는다던가, 그런걸 방지)
	class StructArray<T> where T : struct // 제약조건 'T : struct' == T는 값형식이어야한다
	{
		public T[] Array{ get; set; }
		public StructArray(int size)
		{
			Array = new T[size];
		}
	}

	class RefArray<T>where T : class // 제약조건 'T : class' == T는 참조형식이어야한다
	{
		public T[] Array { get; set; } 
		public RefArray(int size)
		{
			Array = new T[size];
		}
	}

	class Base { }

	class Derived : Base { }			// Base 상속

	class BaseArray<U>where U : Base	// 
	{
		public U[] Array { get; set; }

		public BaseArray(int size)
		{
			Array = new U[size];
		}

		public void CopyArray<T>(T[] source) where T : U // 제약조건 'T : U' == T는 또다른 형식매개변수 U로무터 상속받은 클래스 여야한다.
		{
			source.CopyTo(Array, 0);
		}
	}

	class MainApp
	{
		public static T CreateInstance<T>() where T : new() // 제약조건 'T : new()' == T는 반드시 매개변수가 없는 생성자가 있어야한다.
		{
			return new T(); 
		}

		static void Main(string[] args)
		{
			StructArray<int> a = new StructArray<int>(3);
			a.Array[0] = 0;
			a.Array[1] = 1;
			a.Array[2] = 2;

			RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
			b.Array[0] = new StructArray<double>(5);
			b.Array[1] = new StructArray<double>(10);
			b.Array[2] = new StructArray<double>(1005);

			BaseArray<Base> c = new BaseArray<Base>(3);
			c.Array[0] = new Base();
			c.Array[1] = new Derived();
			c.Array[2] = CreateInstance<Base>();

			BaseArray<Derived> d = new BaseArray<Derived>(3);
			d.Array[0] = new Derived();							// Base형식은 할당이 불가능
			d.Array[1] = CreateInstance<Derived>();
			d.Array[2] = CreateInstance<Derived>();

			BaseArray<Derived> e = new BaseArray<Derived>(3);
			e.CopyArray<Derived>(d.Array);
		}
	}
}
