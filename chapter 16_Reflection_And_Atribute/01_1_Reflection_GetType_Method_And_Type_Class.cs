using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace R_GetType_Method_And_Type_Class
{
	// int형식의 주요정보(상속하는 인터페이스, 필드, 메소드, 프로퍼티 등)을 출력하는 예제코드
	class MainApp
	{
		// 인터페이스
		static void PrintInterfaces(Type type)
		{
			Console.WriteLine("------------------ Interfaces ------------------");

			Type[] interfaces = type.GetInterfaces();
			foreach (Type i in interfaces)
				Console.WriteLine("Name : {0}",i.Name);

			Console.WriteLine();
		}

		// 필드
		static void PrintField(Type type)
		{
			Console.WriteLine("------------------ Field ------------------");

			FieldInfo[] Fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
			foreach (FieldInfo field in Fields)
			{
				String accessLevel = "protected";
				if (field.IsPublic) accessLevel = "public";
				else if (field.IsPrivate) accessLevel = "private";

				Console.WriteLine("Access:{0}, Type:{1}, Name:{2}", accessLevel, field.FieldType.Name, field.Name);
			}

			Console.WriteLine();
		}

		// 메소드 메소드별 프로퍼티
		static void PrintMethod(Type type)
		{
			Console.WriteLine("------------------ Method ------------------");

			MethodInfo[] methods = type.GetMethods();
			foreach (MethodInfo method in methods)
			{
				Console.Write("Type:{0}, Name : {1}, Prameter:", method.ReturnType.Name, method.Name);

				ParameterInfo[] args = method.GetParameters();
				for (int i = 0; i < args.Length; i++) 
				{
					Console.Write("{0}", args[i].ParameterType.Name);
					if (i < args.Length - 1) Console.Write(" ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		// 프로퍼티
		static void PrintProperties(Type type)
		{
			Console.WriteLine("------------------ Properties ------------------");

			PropertyInfo[] Properties = type.GetProperties();
			foreach (PropertyInfo Property in Properties)
				Console.WriteLine("Type:{0}, Name : {1}", Property.PropertyType.Name, Property.Name);

			Console.WriteLine();
		}

		static void Main(string[] args)
		{
			int a = 0;
			Type type = a.GetType();

			PrintInterfaces(type);
			PrintField(type);
			PrintMethod(type);
			PrintProperties(type);
		}
	}
}
