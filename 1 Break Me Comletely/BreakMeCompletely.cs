using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
		public static void ProcessKiller() 
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
			Process process = Process.GetCurrentProcess();

			//ERROR: The process with PID 13348 (child process of PID 10416) could not be terminated.
			//Reason: The process cannot terminate itself.
			//SUCCESS: The process with PID 10416 (child process of PID 7652) has been terminated.
			//С помощью тасккиллер процесс не может устранить сам себя, но это определённо работает на других процессах
			Process.Start("taskkill", $"/F /IM TestTask.exe /T");
			process.Kill();
			Environment.Exit(0);
			

		}
	}
}
