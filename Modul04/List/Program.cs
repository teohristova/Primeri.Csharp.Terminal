using System;
using System.Collections.Generic;


namespace ListExplore

{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//defenicii
			string  userinput = " ";
			List <int> _list= new List <int> ();
			_list.Add  (5);
			_list.Add (3);
			_list.Add (9);
			//vhod
			do {
				Console.Write ("?");
				userinput = Console.ReadLine ();
				//add valves
				if (userinput.ToLower (). Contains ("add"))
				{
					try 
					{
						int _add = 0;
						if (int.TryParse (userinput.Split (' ') [1], out _add)) {
							_list.Add (_add);
						}
					} catch {
					}
				}

				//review
				if (userinput.Contains ("show")) {
					Console.Write ("list:");
					for (int i = 0; i < _list.Count; i++) {
						Console.Write (_list [i]);
						if (i < _list.Count - 1)
							Console.Write (",");
					}
					Console.WriteLine ();
				
			
			}
				//size
			if (userinput.ToLower (). Contains ("size"))
			{
				Console.WriteLine ( "Дължината на списъкът е:" + _list.Count.ToString()+"\n");
			}
			}
			while (userinput != "exit");
				
		}
	}
}


	




