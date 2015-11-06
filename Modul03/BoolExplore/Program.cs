using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int [] _i = new int[] { 4, 3, 2 };
			int _iu = Convert.ToInt32 (Console.ReadLine ( ));
//			bool _chek01 = (_iu <= _i.Length);
//			bool _chek02 = (_iu >0);
//			bool _exp01 = _chek01 && _chek02; // Логическо и ; "&&''
//			bool _exp02 = _chek01 || _chek02; // Логическо и ; "||''
//			bool _exp03 = !_chek01 ; // Логическо отрицание ; "!''
//			
//			Console.WriteLine ("/nЛогическо И :   " + _exp01.ToString());
//			Console.WriteLine ("/nЛогическо ИЛИ :  " + _exp02.ToString());
//			Console.WriteLine ("/nОтрицание на " +  _chek01.ToString() + ":"+ _exp03.ToString());
//			Console.ReadKey ();

			if (_iu > 0 && _iu <= _i.Length) { 
				Console.WriteLine (_i [_iu - 1]);
			} else {
				if (_iu >= _i.Length) {
					Console.WriteLine ("Индексът е прекалено голям");
				}
				if (_iu <0) {
					Console.WriteLine ("Индексът е прекалено малък");
				}
			}
			Console.ReadKey ();
	
	}
	}
}
