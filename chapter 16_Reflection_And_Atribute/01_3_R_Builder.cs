using System;
using System.Reflection;
using System.Reflection.Emit;	// 이게 있어야함

namespace R_Builder
{
	// Builder를 이용하여 새로운 형식을 만들고 사용해보자
	// 사용요령 :
	// 1. AsssemblyBuilder로 어셈블리만든다
	// 2. ModuleBuilder로 1.의 어셈블리안에 모듈을 생성해 삽입
	// 3. 2.의 모듈안에 TypeBuilder로 클래스(형식)을 만들어 삽입
	// 4. 3.의 클래스안에 MethodBuilder로 만든 메소드나 PropertyBuilder로 만든 프로퍼티 삽입
	// 5. 4.에서 만든게 메소드라면, ILGenerator로 메소드안에 CPU가 실행할 IL명령들을 삽입 
	class MainApp
	{
		static void Main()
		{
			// 1. AsssemblyBuilder로 어셈블리만든다
			AssemblyBuilder newAssembly =
				AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);

			// 2. ModuleBuilder로 1.의 어셈블리안에 모듈을 생성해 삽입
			ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");

			// 3. 2.의 모듈안에 TypeBuilder로 클래스(형식)을 만들어 삽입
			TypeBuilder newType = newModule.DefineType("Sum1To100");

			// 4. 3.의 클래스안에 MethodBuilder로 만든 메소드나 PropertyBuilder로 만든 프로퍼티 삽입
			MethodBuilder newMethod = newType.DefineMethod("Calculate", MethodAttributes.Public, typeof(int), new Type[0]);
			//																					  반환형식		매개변수

			// 5. 4.에서 만든게 메소드라면, ILGenerator로 메소드안에 CPU가 실행할 IL명령들을 삽입 
			ILGenerator generator = newMethod.GetILGenerator();

			generator.Emit(OpCodes.Ldc_I4, 1);	// 32비트 정수 1을 계산 스택에 넣는다.

			for(int i = 2; i <= 100; i++)
			{
				generator.Emit(OpCodes.Ldc_I4, i);	// 32비트 정수 i를 계산스택에 넣는다.
				generator.Emit(OpCodes.Add);		// 계산스택에 담겨있는 두 값을 더 계산한다음 그 결과값을 다시 계산스택에 넣는다.
			}

			generator.Emit(OpCodes.Ret);			// 계산스택에 담겨있는 값을 반환
			newType.CreateType();

			object sum1To100 = Activator.CreateInstance(newType);
			MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculate");
			Console.WriteLine(Calculate.Invoke(sum1To100, null));

		}
	}
}
