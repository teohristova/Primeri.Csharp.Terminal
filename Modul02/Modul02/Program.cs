using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			//Дефиниране на променливи
			int a = 0; int b = 0;
			int sum = 0;

			//Събиране на числа
			a = 10;
			b = 10;

			sum = a + b;

			//Писане в конзола
			Console.Write (a);
			Console.Write ('+');
			Console.Write (b);
			Console.Write ('=');
		
			Console.WriteLine ( sum );
			//Допълнителни оператори
			Console.WriteLine ("\nIzpolzwane na +=");
				a+=b;
				Console.WriteLine (a);
			Console.WriteLine ("\nIzpolzwane na -=");
			a-=b;
			Console.WriteLine (a);
			Console.WriteLine ("\nIzpolzwane na *=");
			a*=b;
			Console.WriteLine (a);
			Console.WriteLine ("\nIzpolzwane na ++");
			a++;
			Console.WriteLine (a);
			Console.WriteLine ("Standartno delene "+(7/3).ToString());
			Console.WriteLine ("Delene ostatyk "+(7%3).ToString());
			Console.ReadKey ();
		} 
	}
}
