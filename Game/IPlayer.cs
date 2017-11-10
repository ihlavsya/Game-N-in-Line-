using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    public enum PlayerCell
    {
        Empty = 0,
        Hero,
        Antagonist
    }
    public interface IPlayer
    {
        Color playerColor { get; set; }
        void MakeStep(int col, FieldContext gameProcess, PlayerCell first);
    }

    public class RealPlayer : IPlayer
    {
        public Color playerColor { get; set; }
        public RealPlayer(Color color)
        {
            playerColor = color;
        }
        public void MakeStep(int col, FieldContext gameProcess, PlayerCell first)
        {
            gameProcess.FillField(col, PlayerCell.Hero);
        }

        public void GetFromConsoleUserStep(FieldContext gameProcess, PlayerCell first)
        {

            string a = Console.ReadLine();
            int col = 0;
            for (int i = 0; i < a.Length; i++)
            {
                col *= 10;
                int c = a[i] - '0';
                col += c;
            }
            MakeStep(col, gameProcess, first);
        }
    }

    public class Win
    {
<<<<<<< HEAD
        public int W { get; set; }
=======
        public int W{ get; set; }
>>>>>>> 1017f8ee37edad532daca0d0f23e36f9b1c21e7f
        public Win(int k)
        {
            W = k;
        }
    }

    public class BotPlayer : IPlayer
    {
        // Do not use properties with lower case if its public.
        public Color playerColor { get; set; }
        public BotPlayer(Color color)
        {
            playerColor = color;
        }
<<<<<<< HEAD
        public void MakeStep(int col, FieldContext gameProcess, PlayerCell first)
=======

        public void MakeStep(int col, FieldContext gameProcess,PlayerCell first)
>>>>>>> 1017f8ee37edad532daca0d0f23e36f9b1c21e7f
        {
            // What is 'k' ??
            int k = 0;
            for (int i = 0; i < 2 * gameProcess.N - 1; i++)
                k += gameProcess.FreePositions[i];
            if (k == 1)
            {
                if (gameProcess.Field[0, gameProcess.N] == PlayerCell.Hero)
                {
                    gameProcess.Field[gameProcess.FreePositions[gameProcess.N - 1], gameProcess.N - 1] = PlayerCell.Antagonist;
                    gameProcess.FreePositions[gameProcess.N - 1]++;
                }
                else
                {
                    gameProcess.Field[gameProcess.FreePositions[gameProcess.N], gameProcess.N] = PlayerCell.Antagonist;
                    gameProcess.FreePositions[gameProcess.N]++;
                }
            }
            else
            {
                // What is 'a'. Please give good variables name.
                Win a = new Win(0);
                StepScore s = Minimax(gameProcess, first, PlayerCell.Antagonist, 0, -1, a);
                col = s.Step;
                gameProcess.FillField(col, PlayerCell.Antagonist);
            }
            k++;
        }

        private struct StepScore
        {
            public int Step;
            public long Score;

            public readonly static StepScore ZeroScore = new StepScore { Score = 0, Step = 0 };
        }

<<<<<<< HEAD
        private static StepScore StepScoreZero = new StepScore { Step = 0, Score = 0 };
=======
        // Why its static?
        private static StepScore StepScoreZero;
>>>>>>> 1017f8ee37edad532daca0d0f23e36f9b1c21e7f

        StepScore Minimax(FieldContext gameProcess, PlayerCell first, PlayerCell flag, int deep, int col, Win aWin)
        {
            StepScore s = StepScoreZero;

            if (deep != 0)
            {
                gameProcess.Field[gameProcess.FreePositions[col], col] = gameProcess.GetOppositePlayer(flag);//(flag % 2) + 1;-opposite
                gameProcess.FreePositions[col]++;
            }
            int c = gameProcess.EndOfTheGame(gameProcess.GetOppositePlayer(flag));

            aWin.W = 0;
            if (c != -1 && deep == 1)
            {
                s.Score = Heuristic.heuristic(gameProcess, first, gameProcess.GetOppositePlayer(flag));
                s.Step = col;
                aWin.W = 1;
                gameProcess.FreePositions[col]--;
                gameProcess.Field[gameProcess.FreePositions[col], col] = 0;
                return s;
            }
            if (c != -1 || deep == 3)
            {
                if (col != -1)
                {
                    s.Score = Heuristic.heuristic(gameProcess, first, gameProcess.GetOppositePlayer(flag));
                    s.Step = col;
                    gameProcess.FreePositions[col]--;//не работает
                    gameProcess.Field[gameProcess.FreePositions[col], col] = 0;
                    return s;
                }
            }

            StepScore a = StepScoreZero;
            a.Step = -1;

            if ((deep + 1) % 2 == 0)
                // You can use long.MinValue if its Ok for you logic.
                a.Score = (long)-1e15;
            else
                a.Score = (long)1e15;

            for (int i = 0; i < gameProcess.QuanCols; i++)
            {
                if (gameProcess.FreePositions[i] != gameProcess.QuanRows)
                {
                    StepScore f = Minimax(gameProcess, first, gameProcess.GetOppositePlayer(flag), deep + 1, i, aWin);
                    if (aWin.W != 0)
                    {
                        return f;
                    }
                    if ((deep + 1) % 2 == 0 && a.Score < f.Score)
                    {
                        a.Score = f.Score;
                        a.Step = i;
                    }

                    if ((deep + 1) % 2 != 0 && a.Score > f.Score)
                    {
                        a.Score = f.Score;
                        a.Step = i;
                    }
                }
            }
            if (deep != 0)
            {
                gameProcess.FreePositions[col]--;
                gameProcess.Field[gameProcess.FreePositions[col], col] = 0;
            }
            return a;
        }
    }
}
