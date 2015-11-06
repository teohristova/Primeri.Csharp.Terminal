using System;

namespace BoolExplore2
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
//			_iu = (_iu <= _i.Length) ? _iu : 3;
//			_iu = (_iu >0) ? _iu : 1;
			switch (_iu) {
			case 1 : 
				{
					Console.WriteLine ( "1-ви елемент на масива е:");	
			 		Console.WriteLine ( _i[_iu-1]);
					break;
				}
			case 2:   
				{
					Console.WriteLine ( "2-ри елемент на масива е:");	
					Console.WriteLine ( _i[_iu-1]);
					break;
				}
			case 3:   
				{
					Console.WriteLine ( "3-ти елемент на масива е:");	
					Console.WriteLine ( _i[_iu-1]);
					break;
				}
			default : 
				
				{ 
					Console.WriteLine ("В масива няма елемент с този индекс. \n\n\nМоля изберете индекс между 1 и 3");
					break;
				}
					
			}
			Console.ReadKey ();
		}
	}
}