using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 5, b = 0;
			//Vavejdane na vhodni parametri
			Console.Write ("Molq vavedeta a=");
			b = Convert.ToInt32 (Console.ReadLine ());
			// Pechat na rezultat
			Console.WriteLine ("a+b="+(a+b).ToString()+"\n\n\n");

		}
	}
}
