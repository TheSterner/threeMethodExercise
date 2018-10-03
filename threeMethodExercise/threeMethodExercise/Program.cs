using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeMethodExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number between 1-50.");
			int userNumber = Convert.ToInt32(Console.ReadLine());
			int addedUserNumber = MathClass.AddUserNumber(userNumber);
			int minusUserNumber = MathClass.SubUserNumber(userNumber);
			int timesUserNumber = MathClass.TimesUserNumber(userNumber);
			Console.WriteLine("Your number plus 9 is " + addedUserNumber);
			Console.WriteLine("Your number minus 5 is " + minusUserNumber);
			Console.WriteLine("Your number times 3 is " + timesUserNumber);
			Console.WriteLine("Thanks for playing along.");
			Console.ReadLine();
		}
		
		

	
		
		


		
		
		
	}
}
