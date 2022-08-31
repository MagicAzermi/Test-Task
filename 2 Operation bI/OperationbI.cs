using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task._2OperationbI.Break_Me_Comletely;

namespace Test_Task
{

	class Number
	{
		static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;
		readonly int _number;

		public Number(int number)
		{
			_number = number;
		}

		public override string ToString()
		{
			return _number.ToString(_ifp);
		}
		public static string operator +(Number n1, string n2) => (new Number(n1._number + Int32.Parse(n2))).ToString();

		public static void OperationbI()
		{
			int someValue1 = 10;
			int someValue2 = 5;

			string result = new Number(someValue1) + someValue2.ToString(_ifp);
			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}
