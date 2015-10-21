using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Дефиниране на таблица
			String [,] table = new string [2,3];
			// Въвеждане на 1-ви ред
			table [0,0]="Теодора";table [0,1]="Христова";table [0,2]="47";

			// Въвеждане на 2-ri ред
			table [1,0]="Христо";table [1,1]="Тодоров";table [1,2]="74";
			//Печат
			Console.WriteLine ("Кой ред искате да видите?  ");
			int  _index= Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ((table[_index-1,0])[0]+". "+table[_index-1,1]+"  "+table[_index-1,2]+"г.");

		}
	}
}
    