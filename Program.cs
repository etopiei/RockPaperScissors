using System;

namespace Rock_Paper_Scissors
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			System.Console.WriteLine ("Type 'R' for Rock,");
			System.Console.WriteLine ("Type 'P' for Paper");
			System.Console.WriteLine ("Type 'S' for Scissors");
			System.Console.WriteLine ("Press enter to submit:");

			string userinput = System.Console.ReadLine ();

			if (userinput == "R") {

				System.Console.WriteLine ("You chose Rock!");

			} else if (userinput == "P") {

				System.Console.WriteLine ("You chose Paper!");

			} else if (userinput == "S") {

				System.Console.WriteLine ("You chose Scissors!");

			} else {

				System.Console.WriteLine ("What is your problem, son?");

			}

			ComputerChoice MakeDecision = new ComputerChoice ();
			MakeDecision.RandomChoice (userinput);
		}
	}

	class ComputerChoice {

		public void RandomChoice(string userinput) {

			Random rnd = new Random();
			int random = rnd.Next (1, 3);
			//System.Console.WriteLine (random);

			if (random == 1) {

				System.Console.WriteLine ("Computer chose Rock");

			} else if (random == 2) {

				System.Console.WriteLine ("Computer chose Paper");

			} else if (random == 3) {

				System.Console.WriteLine ("Computer chose Scissors");

			}

			CheckWin (userinput, random);
		}

			public void CheckWin(string userinput, int random) {

			if ((((random == 1) && (userinput == "R")) || ((random == 2) && (userinput == "P"))) || ((random == 3) && (userinput == "S"))) {

				Draw ();

			} else if ((((random == 1) && (userinput == "P")) || ((random == 2) && (userinput == "S"))) || ((random == 3) && (userinput == "R"))) {

				Win ();
			} else {

				Lose ();
			}
		}

		public void Draw() {

			System.Console.WriteLine ("You Drew!");

		}

		public void Win() {

			System.Console.WriteLine ("You Won!");
		}

		public void Lose() {

			System.Console.WriteLine ("You Lost!");

		}

	}
		
}
