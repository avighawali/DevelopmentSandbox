using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewHelperConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Multiplication Function Testing

			Console.WriteLine(string.Format("Enter First Number:"));
			int firstParam = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(string.Format("Enter Second Number:"));
			int secondParam = Convert.ToInt32(Console.ReadLine());

			int rtnValue = Multiplication.Multiply(firstParam, secondParam);
			Console.WriteLine(string.Format("Final Output: {0}", rtnValue));

			Console.ReadKey();

			#endregion

		}
	}
}
