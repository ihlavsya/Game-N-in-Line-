using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public static class Heuristic
    {
        public static long heuristic(FieldContext gameProcess, PlayerCell first, PlayerCell flag)
        {
            long score = 0;
            score = HeuristicHero(gameProcess.N, gameProcess.Field, first, flag);

            if (Math.Abs(score) >= 1e12)
            {
                return score;
            }

            long oppositeScore = 0;
            oppositeScore = heuristicAntagonist(gameProcess.N, gameProcess.Field, first, gameProcess.GetOppositePlayer(flag)); //при этой и нижней строке одинаковый результат
                                                                                      //	oppositeScore = heuristicUser(n, field, first, getOppositeFlag(flag));
            score += oppositeScore;
            return score;
        }

        private static long factorial(long num)
        {
            long fact = 1;
            for (long i = num; i > 0; i--)
            {
                fact *= i;
            }
            return fact;
        }

        private static long HeuristicLineHero(Line[] arr, int n, PlayerCell first, PlayerCell flag)
        {
            long sum = 0;

            for (int i = 1; i < arr[0].length; i++)
            {

                if (arr[i].length == n)
                {
                    return (long)1e12;
                }

                sum += factorial(arr[i].length + 2);
            }

            return sum;
        }

        private static long HeuristicLineAntagonist(Line[] arr, int n, PlayerCell first, PlayerCell flag)
        {
            long sum = 0;

            for (int i = 1; i < arr[0].length; i++)
            {
                sum += factorial(arr[i].length + 2);
            }

            return sum;

        }
        private static long HeuristicHero(int n, PlayerCell[,] field, PlayerCell first, PlayerCell flag)
        {
            long score = 0;

            Line[] arr = LinesCounter.DiagLeft(n, field, flag);
            score += HeuristicLineHero(arr, n, first, flag);

            arr = LinesCounter.DiagRight(n, field, flag);
            score += HeuristicLineHero(arr, n, first, flag);

            arr = LinesCounter.HorLines(n, field, flag);
            score += HeuristicLineHero(arr, n, first, flag);

            arr = LinesCounter.VerLines(n, field, flag);
            score += HeuristicLineHero(arr, n, first, flag);

            if (flag == PlayerCell.Antagonist)
            {
                score = (-1) * score;
            }

            return score;
        }

        private static long heuristicAntagonist(int n, PlayerCell[,]field, PlayerCell first, PlayerCell flag)
        {
            long score = 0;

            Line[] arr = LinesCounter.DiagLeft(n,field,flag);
            score += HeuristicLineAntagonist(arr, n, first, flag);

            arr = LinesCounter.DiagRight(n, field, flag);
            score += HeuristicLineAntagonist(arr, n, first, flag);

            arr = LinesCounter.HorLines(n, field, flag);
            score += HeuristicLineAntagonist(arr, n, first, flag);

            arr = LinesCounter.VerLines(n, field, flag);
            score += HeuristicLineAntagonist(arr, n, first, flag);

            if (flag == PlayerCell.Antagonist)//bot
            {
                score = (-1) * score;
            }

            return score;
        }
    }
}
