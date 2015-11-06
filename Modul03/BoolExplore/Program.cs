using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int [] _i = new int[] { 4, 3, 2 };
			int _iu = 0;
			string _input = "0";
			Console.WriteLine ( "\nВъведете индекс :  ");
				_input = Console.ReadLine ();

			bool _check01=int.TryParse (_input, out _iu);
			bool _check02 = (_iu <= _i.Length);
			bool _check03 = (_iu >0);

				if (_check01 && _check02  && _check03) 
				{ 
					Console.WriteLine ( _i[_iu-1]);
				}  

				if (! _check01) 
				{ 
					Console.WriteLine ("\n\n\nИндексът трябва да е число");
			}  

				if  (! _check02)  {
					Console.WriteLine ("\n\n\nИндексът е прекалено голям");
				}
			
				if (! _check03 && _check01 ) {
					Console.WriteLine ("\n\n\nИндексът е прекалено малък");
				}
		

		
			Console.ReadKey ();
	
	}
	}
}
