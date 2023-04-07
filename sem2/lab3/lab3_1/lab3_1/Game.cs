using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    public class Game
    {
        public int[,] field = new int[3, 3];
        public bool current_player = true;
        public bool winned = false;
        public int[] win_combo = new int[4];
        public int Player1Score = 0, Player2Score = 0;
        public int moveNum = 0;
        public int playground_size, cross_sign, circle_sign;

        public Game(int size, int _cross_sign, int _circle_sign)
        {
            playground_size = size;
            cross_sign = _cross_sign;
            circle_sign = _circle_sign;
        }
        
        public void NewGame()
        {
            field = new int[3, 3];
            current_player = true;
            winned = false;
            win_combo = new int[4];
            moveNum = 0;
        }
        public void ResetScore()
        {
            Player1Score = 0;
            Player2Score = 0;
            NewGame();
        }
        public bool CheckWin()
        {
            int sign = current_player ? cross_sign : circle_sign;
            for (int i = 0; i < playground_size; i++)
            {
                if (field[i, 0] == sign && field[i, 1] == sign && field[i, 2] == sign)
                {
                    winned = true;
                    win_combo = new int[] { i, 0, i, 2 };
                    return true;
                }

                else if (field[0, i] == sign && field[1, i] == sign && field[2, i] == sign)
                {
                    winned = true;
                    win_combo = new int[] { 0, i, 2, i };
                    return true;

                }
            }

            if (field[0, 0] == sign && field[1, 1] == sign && field[2, 2] == sign)
            {
                winned = true;
                win_combo = new int[] { 0, 0, 2, 2 };
                return true;

            }
            else if (field[0, 2] == sign && field[1, 1] == sign && field[2, 0] == sign)
            {
                winned = true;
                win_combo = new int[] { 0, 2, 2, 0 };
                return true;
            }
            return false;
        }
        public void MakeMove(int i, int j)
        {
            field[i, j] = current_player ? cross_sign : circle_sign;
            moveNum++;
            if (CheckWin())
            {
                _ = current_player ? Player1Score++ : Player2Score++;
                return;
            }
            current_player = !current_player;
        }
    }
}
