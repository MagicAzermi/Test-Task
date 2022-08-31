using System;
using System.Globalization;
using Test_Task;
using Test_Task._2OperationbI.Break_Me_Comletely;
using Test_Task._3;
using Test_Task._4;
using Test_Task._5;

class Program
{

	static void Main(string[] args)
	{

		//Второе задание
		Number.OperationbI();
		//Третье задание
		new[] { 1, 2, 3, 4 }.EnumerateFromTail(2);
		//Четвертое задание
		int[] i = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		SortTask.Sort(i, 5, 15);
		//Пятое задание
		string[] vs = new[] { "", ""};
		FlyToElephant.NotMain(vs);
		//Первое задание
		BreakMeCompletely.ProcessKiller();
	}
}
