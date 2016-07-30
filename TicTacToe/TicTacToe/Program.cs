using System;


namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            TicTacToeGame game = new TicTacToeGame();
            Console.WriteLine("The game is satrted...");
            var op=MyEnum.Empty;
            while (game.IsGameOver!=0 && game.IsGameOver!=1 && game.IsGameOver!=(-1))
            {
                Console.WriteLine("Please choose move ... X or O :");
                var readLine = Console.ReadLine();
                if (readLine != null)
                    if(readLine == "o" || readLine == "O")
                        op=MyEnum.O;
                    else if (readLine == "x" || readLine == "X")
                        op = MyEnum.X;
                Console.WriteLine("Please enter place :");
                var x = Convert.ToInt32(Console.ReadLine());
                var y = Convert.ToInt32(Console.ReadLine());
                game.SetMove(op, x, y);
                game.ShowBoard();
            }
            switch (game.IsGameOver)
            {
                case 1:
                     Console.WriteLine("Congrats X !!!");
                     break;
                case -1:
                    Console.WriteLine("Congrats O !!!");
                    break;
                default:
                    Console.WriteLine("Draw !!!");
                    break;
            }
        }
    }
}
