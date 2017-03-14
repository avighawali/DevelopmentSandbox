using System;

namespace InterviewHelperConsoleApp
{
	/* **
	 * Interview Question: Write a function which accept 2 integer parameters and output of the function is multiplication of 2 numbers. 
	 * Note: Please do not use any mulitiplication function or operator to generate the output.
	 * * */
	public static class Multiplication
	{
		public static int Multiply(int firstParam, int secondParam)
		{
			int rtnValue = 0;

			// if both input numbers are 0, then output will be 0.
			if(firstParam == 0 && secondParam == 0)
			{
				return rtnValue;
			}

			int loop = 0;
			int multiplier = 0;

			// if both input numbers are negative, then convert both numbers into positive.
			if(Math.Sign(firstParam) == -1 && Math.Sign(secondParam) == -1)
			{
				firstParam = Math.Abs(firstParam);
				secondParam = Math.Abs(secondParam);
			}

			loop = (firstParam <= secondParam) ? secondParam : firstParam;
			multiplier = (firstParam <= secondParam) ? firstParam : secondParam;

			for (int i = 0; i < loop; i++)
			{
				rtnValue += multiplier;
			}

			return rtnValue;
		}
	}
}
