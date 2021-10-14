using System;

namespace TicTactToe
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1;
            Player player2;

            Console.WriteLine("Welcome to Tic-Tac-Toe");
            Console.Write("Provide the name for player 1 (X): ");
            player1 = new Player(Console.ReadLine());
            Console.Write("Provide the name for player 2 (O): ");
            player2 = new Player(Console.ReadLine());
            Game tempGame = new Game(player1, player2);
            tempGame.startGame();
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }


    class Player
    {
        private string name;

        public Player(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }

    class Game
    {
        private Player player1;
        private Player player2;

        private char[,] board = {
            {'1','2','3'},
            {'4','5','6' },
            {'7','8','9' }
        };

        public Game(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void startGame()
        {
            int counter = 0;
            bool player1InTurn = true;
            

            while(counter < 9)
            {
                displayBoard();
                int optionSelected;
                char mark;
                if (player1InTurn)
                {
                    Console.Write("On turn: {0} (X). Provide the number from the board: ",player1.getName());
                    mark = 'X';
                }
                else
                {
                    Console.Write("On turn: {0} (O). Provide the number from the board: ", player2.getName());
                    mark = 'O'; 
                }

                optionSelected = Convert.ToInt32(Console.ReadLine());
                if (checkValidOption(optionSelected))
                {
                    updateBoard(optionSelected, mark);
                    displayBoard();
                    if (checkForAWinner(mark))
                    {
                        // we have a winner
                        displayWinner(mark);
                        return;
                    }
                    counter++;
                    if(counter == 9 && checkForAWinner(mark)== false)
                    {
                        Console.WriteLine("We don't have a winner :( Continue playing. ");
                    }
                    player1InTurn = !player1InTurn;
                }

            }

        }

        public void updateBoard(int optionSelected, char mark)
        {
            switch (optionSelected)
            {
                case 1: board[0, 0] = mark; break;
                case 2: board[0, 1] = mark; break;
                case 3: board[0, 2] = mark; break;
                case 4: board[1, 0] = mark; break;
                case 5: board[1, 1] = mark; break;
                case 6: board[1, 2] = mark; break;
                case 7: board[2, 0] = mark; break;
                case 8: board[2, 1] = mark; break;
                case 9: board[2, 2] = mark; break;
            }
        }
        public void displayBoard()
        {
            Console.Clear();
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("     |     |");
        }
        
        public bool checkValidOption(int optionSelected)
        {
            return true;
        }

        public bool checkForAWinner(char mark)
        {
            if ((board[0, 0] == mark) && (board[0, 1] == mark) && (board[0, 2] == mark)
                       || (board[1, 0] == mark) && (board[1, 1] == mark) && (board[1, 2] == mark)
                       || (board[2, 0] == mark) && (board[2, 1] == mark) && (board[2, 2] == mark)
                       || (board[0, 0] == mark) && (board[1, 0] == mark) && (board[2, 0] == mark)
                       || (board[0, 1] == mark) && (board[1, 1] == mark) && (board[2, 1] == mark)
                       || (board[0, 2] == mark) && (board[1, 2] == mark) && (board[2, 2] == mark)
                       || (board[0, 0] == mark) && (board[1, 1] == mark) && (board[2, 2] == mark)
                       || (board[0, 2] == mark) && (board[1, 1] == mark) && (board[2, 0] == mark))
            {
                return true;

            }
            return false;
        }
        
        public void displayWinner(char mark)
        {
            if (mark == 'X')
                Console.WriteLine("Congratulations. {0} has won :) ", player1.getName());
            else
                Console.WriteLine("Congratulations. {0} has won :) ", player2.getName());
        }
    }
}
