using System;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
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

			_ = Console.ReadLine();
		}

		private static void ExceptionGenerator()
		{
			throw new NotImplementedException();
		}
	}
}
