using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			String [] row = new string [3];
			row [0]="Peд 1";
			row [1]="Peд 2";
			row [2]="Peд 3";
			Console.WriteLine ( "Масивът row :"+row [0]+", "+row [1]+", "+row [2]+"\n");
			String[] parse= "1,2,3,4,5,6,7,8,9".Split (',');

			Console.WriteLine ("Броят на елементите на масива: \n" + "1,2,3,4,5,6,7,8,9\n\ne: " + parse.Length);
			String list1=string.Join (";", parse);
			Console.WriteLine ( "Новият стринг e :\n"+list1+"\n\n");
		}
	}
}
