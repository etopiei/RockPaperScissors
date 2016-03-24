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
            int player1 = 0;

            switch (userinput)
            {

                case "R":
                    Console.WriteLine("You chose Rock");
                    player1 = 1;
                    break;
                case "P":
                    Console.WriteLine("You chose Paper");
                    player1 = 2;
                    break;
                case "S":
                    Console.WriteLine("You chose Scissors");
                    player1 = 3;
                    break;
                default:
                    Console.WriteLine("Incorrect Input, please ensure you use uppercase.");
                    break;

            }

            ComputerChoice MakeDecision = new ComputerChoice();
            MakeDecision.RandomChoice(player1);
        }
    }

    class ComputerChoice
    {

        public void RandomChoice(int player1)
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

            CheckWin(player1, random);
        }
            

        public void CheckWin(int player1, int opponent) {

            if (player1 == opponent)
            {
                
                Draw();

            }
            else if (((player1 == 1) && (opponent == 3)) || ((player1 == 2) && (opponent == 1)) || ((player1 == 3) && (opponent == 2)))
            {
                
                Player1Won();

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

        public void Player1Won()
        {

            Console.WriteLine("You Won!");
        }

        public void Lose()
        {

            Console.WriteLine("You Lost!");

        }

    }
		
}