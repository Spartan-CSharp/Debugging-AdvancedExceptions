using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				ExceptionGenerator();
			}
			catch ( NotImplementedException ex )
			{
				Console.WriteLine("You did not implement a mathod.");
				Console.WriteLine(ex);
			}
			catch ( Exception ex )
			{
				Console.WriteLine("A general exception occurred");
				Console.WriteLine(ex);
			}
			finally
			{
				Console.WriteLine("Clean up code: I always run!");
			}

			Console.ReadLine();
		}

		private static void ExceptionGenerator()
		{
			throw new NotImplementedException();
		}
	}
}
