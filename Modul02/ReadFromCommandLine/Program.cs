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
			string test = "1";
			test += ", 2";
			test += ", 100";
			test += ", 4";
			test += ", 5";
			Console.WriteLine ("Sum +=  " + test + "\n");
			test = test.Replace (", ", ";");
			Console.WriteLine ("подмяна: " + test + "\n");
			Console.WriteLine ("Split -3: " + test.Split (';')[2]);
		}
	}
}
