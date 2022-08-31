using System;
using System.Globalization;
using Test_Task;
using Test_Task._2OperationbI.Break_Me_Comletely;
using Test_Task._3;
using Test_Task._4;

class Program
{

	static void Main(string[] args)
	{
		//Первое задание
		BreakMeCompletely.breakMeCompletely();
		//Второе задание
		Number.OperationbI();
		new[] { 1, 2, 3, 4 }.EnumerateFromTail(2);
		SortTask.Sort(5, 15);

	}
}
