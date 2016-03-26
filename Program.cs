using System;

namespace Rock_Paper_Scissors
{

    public enum Options {
        Rock,
        Paper,
        Scissors
    }

    class Game
    {

        public static void Main(string[] args)
        {
            Game newgame = new Game();
            newgame.Play();

        }
        public void Play()
        {

            Console.WriteLine("Type 'R' for Rock,");
            Console.WriteLine("Type 'P' for Paper");
            Console.WriteLine("Type 'S' for Scissors");
            Console.WriteLine("Press enter to submit:");

            string userinput = Console.ReadLine();
            int player1 = (int)Options.Rock;
            bool noerrors = true;

            ComputerChoice MakeDecision = new ComputerChoice();

            switch (userinput)
            {

                case "R":
                    Console.WriteLine("You chose Rock");
                    player1 = (int)Options.Rock;
                    MakeDecision.RandomChoice(player1);
                    break;
                case "P":
                    Console.WriteLine("You chose Paper");
                    player1 = (int)Options.Paper;
                    MakeDecision.RandomChoice(player1);
                    break;
                case "S":
                    Console.WriteLine("You chose Scissors");
                    player1 = (int)Options.Scissors;
                    MakeDecision.RandomChoice(player1);
                    break;
                default:
                    noerrors = false;
                    Reset(noerrors);
                    break;

            }
                    
        }

        public void Reset(bool error) 
        {

            Console.Clear();

            if (error == false)
            {

                Console.WriteLine("Incorrect Input, please ensure you use uppercase.");
                Play();

            }
            else
            {

                Play();

            }

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
                    random = (int)Options.Rock;
                    break;
                case 2:
                    Console.WriteLine("Computer chose Paper");
                    random = (int)Options.Paper;
                    break;
                case 3:
                    Console.WriteLine("Computer chose Scissors");
                    random = (int)Options.Scissors;
                    break;

            }

            CheckWin(player1, random);
        }
            

        public void CheckWin(int player1, int opponent) {

            if (player1 == opponent)
            {
                
                Draw();

            }
            else if (((player1 == (int)Options.Rock) && (opponent == (int)Options.Scissors)) || ((player1 == (int)Options.Paper) && (opponent == (int)Options.Rock)) || ((player1 == (int)Options.Scissors) && (opponent == (int)Options.Paper)))
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
            PlayAgain();

        }

        public void Player1Won()
        {

            Console.WriteLine("You Won!");
            PlayAgain();
        }

        public void Lose()
        {

            Console.WriteLine("You Lost!");
            PlayAgain();

        }

        public void PlayAgain()
        {
            
            bool playagain = true;
            Console.WriteLine("Play Again? Enter 'y' for yes, enter 'n' for no...");
            string getanswer = Console.ReadLine();

            if (getanswer == "y")
            {

                playagain = true;
                Game newgame = new Game();
                newgame.Reset(playagain);

            }
            else
            {

                playagain = false;

            }

        }

    }
		
}