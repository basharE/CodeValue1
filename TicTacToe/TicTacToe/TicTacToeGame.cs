using System;

namespace TicTacToe
{
    enum MyEnum {X,O,Empty}

    class TicTacToeGame
    {
        private MyEnum[,] _matrixGame = new MyEnum[3, 3];
        private int _isGameOver;

        public TicTacToeGame()
        {
            for (var i = 0; i < _matrixGame.GetLength(0); i++)
                for (var j = 0; j < _matrixGame.GetLength(1); j++)
                    _matrixGame[i, j] = MyEnum.Empty;
            IsGameOver = 2;
        }

        internal MyEnum[,] MatrixGame
        {
            get{ return _matrixGame; }
            set{ _matrixGame = value; }
        }

        public int IsGameOver
        {
            get { return _isGameOver; }
            set { _isGameOver = value; }
        }
        //b
        public void ShowBoard()
        {
            for (var i = 0; i < MatrixGame.GetLength(0); i++)
            {
                for (var j = 0; j < MatrixGame.GetLength(1); j++)
                    Console.Write("{0,6}",MatrixGame[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        //c
        public bool SetMove(MyEnum move, int x, int y)
        {
            if (MatrixGame[x, y] != MyEnum.Empty) return false;
            else
            {
                MatrixGame[x, y] = move;
                if (CheckDraw())
                {
                    IsGameOver = 0;
                    return true;
                }
                else
                {
                    if (move==MyEnum.X)
                    {
                        IsGameOver = CheckWin(x, y) ? 1 : 2;
                        return true;
                    }
                    else 
                    {
                        IsGameOver = CheckWin(x, y) ? -1 : 2;
                        return true;
                    }
                    
                }
            }  
        }

        private bool CheckWin(int x, int y)
        {
            return CheckX(x, y) || CheckY(x, y) || CheckDiagonal(x, y);
        }

        private bool CheckX(int x, int y)
        {
            if (MatrixGame[x % 3, y] == MatrixGame[(x+1) % 3, y] && MatrixGame[(x+1) % 3, y] == MatrixGame[(x+2) % 3, y])
                return true;
            return false;
        }

        private bool CheckY(int x, int y)
        {
            if (MatrixGame[x, y % 3] == MatrixGame[x, (y+1) % 3] && MatrixGame[x, (y+1) % 3] == MatrixGame[x, (y+2) % 3])
                return true;
            return false;
        }

        private bool CheckDiagonal(int x, int y)
        {
            bool dia1;
            if ((x + y) == 2)
                dia1 = MatrixGame[0, 2] == MatrixGame[2, 0] && MatrixGame[2, 0] == MatrixGame[1, 1];
            else
                dia1 = MatrixGame[x % 3, y % 3] == MatrixGame[(x + 1) % 3, (y + 1) % 3] &&
                        MatrixGame[(x + 1) % 3, (y + 1) % 3] == MatrixGame[(x + 2) % 3, (y + 2) % 3];
            return dia1;
        }

        private bool CheckDraw()
        {
            for (var i = 0; i < _matrixGame.GetLength(0); i++)
                for (var j = 0; j < _matrixGame.GetLength(1); j++)
                    if (_matrixGame[i, j] == MyEnum.Empty)
                        return false;
            return true;
        }
    }
}
