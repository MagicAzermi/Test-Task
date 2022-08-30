using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task._2OperationbI.Break_Me_Comletely
{
	class BreakMeCompletely
	{

		/*static void Main(string[] args)
		{
			try
			{
				FailProcess();
			}
			catch { }

			Console.WriteLine("Failed to fail process!");
			Console.ReadKey();
		}*/
		public static void breakMeCompletely() 
		{
			try
			{
				FailProcess();
			}
			catch { }

			Console.WriteLine("Failed to fail process!");
			Console.ReadKey();
		}

		static void FailProcess()
		{
			//Первый способ вызова исключения - DivideByZeroException
			/*int x = 5;
			int y =  x / 0;*/

			//Второй способ вызова исключения - IndexOutOfRangeException
			/*int[] numbers = new int[5];
			numbers[10] = 1;*/

			//Третий способ вызова исключения - InvalidCastException
			/*object obj = new object();
			int i;
			i = (int)obj;*/

			//Четвёртый способ вызова исключения - throw
			/*int a = 0;
			if (a > 0) 
			{
				throw new Exception("a > 0");
			}*/
		}
	}
}
