using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] _Table = {
				{ "Иван", "Георгиев", "20" },
				{ "Ивана", "Тодорова", "15" },
				{ "Димитър", "Василев", "25" },
				{ "Ивана", "Христова", "23" },
				{ "Иван", "Димитров", "22" },
				{ "Гергана", "Йорданова", "27" }
			};
				Console.WriteLine ( "име".PadRight(12) +  "фамилия".PadRight(12) + "години".PadRight(12));
			Console.WriteLine ( "========================================");
			for (int i = 0; i < _Table.Length/3; i++) {
				for (int j = 0; j <3; j++) {
					Console.Write (_Table [i,j].PadRight(12) ) ;
				};
				Console.WriteLine();

			};
			Console.ReadKey ();
	}
}
}
