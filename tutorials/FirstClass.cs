﻿using System;

namespace tutorials
{
	public class Dude
	{
		private string greetings = "hello I'm dude";

		public void printGreeting() 
		{
			System.Console.WriteLine (greetings);
		}
	}

	public class FirstClass
	{
		static public int Main (string[] args)
		{
			System.Console.WriteLine ("hello world" + " you wrote {0} args", args.Length);
			foreach(string arg in args) {
				System.Console.WriteLine ("Arg is " + arg);
			}
			Dude guy = new Dude ();
			guy.printGreeting ();
			return 0;
		}
	}
}
