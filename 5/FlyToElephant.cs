using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task._5
{
	internal class FlyToElephant
	{

		public static void NotMain(string[] vs)
		{
			TransformToElephant();
			Console.WriteLine("Муха");
			Console.WriteLine("Мухааа");
			Console.WriteLine("Слон");
			Console.WriteLine("Ухоха");
		}

		static void TransformToElephant()
		{
			Console.WriteLine("Слон");
			Console.SetOut(new ConsoleWriter());

		}
		 
		class ConsoleWriter : StringWriter
		{
			TextWriter emptyOut = Console.Out;
			public override void WriteLine(string? value) => Console.SetOut(emptyOut);
		}
	}
}
