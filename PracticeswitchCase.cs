using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewQuestions
{
	class PracticeswitchCase
	{
		public static void Main()
		{
			int input = 2; //change value of this input to see output for different cases 

			// switch with integer type
			switch (input)
			{
				case 1:
					Console.WriteLine("Your input for case 1 is: {0}", input);
					break;
				case 2:
					Console.WriteLine("Your input for case 2 is: {0}", input);
					break;
				default:
					Console.WriteLine("Your input in default case is: {0}", input);
					break;
			}
			int[] number = { 1, 2, 3, 4 };

			if (number.Count() > 0 && number != null)
			{

			}
		}
	}
}
