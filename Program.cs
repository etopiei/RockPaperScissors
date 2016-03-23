using System;

namespace Rock_Paper_Scissors
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Type 'R' for Rock,");
            Console.WriteLine("Type 'P' for Paper");
            Console.WriteLine("Type 'S' for Scissors");
            Console.WriteLine("Press enter to submit:");

            string userinput = Console.ReadLine();

            switch (userinput)
            {

                case "R":
                    Console.WriteLine("You chose Rock");
                    break;
                case "P":
                    Console.WriteLine("You chose Paper");
                    break;
                case "S":
                    Console.WriteLine("You chose Scissors");
                    break;
                default:
                    Console.WriteLine("Incorrect Input, please ensure you use uppercase.");
                    break;

            }

            ComputerChoice MakeDecision = new ComputerChoice();
            MakeDecision.RandomChoice(userinput);
        }
    }

    class ComputerChoice
    {

        public void RandomChoice(string userinput)
        {

            Random rnd = new Random();
            int random = rnd.Next(1, 3);

            switch (random)
            {

                case 1:
                    Console.WriteLine("Computer chose Rock");
                    break;
                case 2:
                    Console.WriteLine("Computer chose Paper");
                    break;
                case 3:
                    Console.WriteLine("Computer chose Scissors");
                    break;

            }

            CheckWin(userinput, random);
        }

        public void CheckWin(string userinput, int random)
        {

            if ((((random == 1) && (userinput == "R")) || ((random == 2) && (userinput == "P"))) || ((random == 3) && (userinput == "S")))
            {

                Draw();

            }
            else if ((((random == 1) && (userinput == "P")) || ((random == 2) && (userinput == "S"))) || ((random == 3) && (userinput == "R")))
            {

                Win();

            }
            else
            {

                Lose();
            }
        }

        public void Draw()
        {

            Console.WriteLine("You Drew!");

        }

        public void Win()
        {

            Console.WriteLine("You Won!");
        }

        public void Lose()
        {

            Console.WriteLine("You Lost!");

        }

    }
		
}