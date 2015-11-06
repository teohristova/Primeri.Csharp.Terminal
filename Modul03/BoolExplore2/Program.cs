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
			_iu = (_iu <= _i.Length) ? _iu : 3;
			_iu = (_iu >0) ? _iu : 1;
			 Console.WriteLine ( _i[_iu-1]);
			Console.ReadKey ();
		}
	}
}
