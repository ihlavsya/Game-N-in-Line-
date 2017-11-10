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
            score = HeuristicHero(gameProcess, first, flag);

            if (Math.Abs(score) >= 1e12)
            {
                return score;
            }

            long oppositeScore = 0;
            oppositeScore = heuristicAntagonist(gameProcess, first, gameProcess.GetOppositePlayer(flag)); //при этой и нижней строке одинаковый результат
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
        private static long HeuristicHero(FieldContext gameProcess, PlayerCell first, PlayerCell flag)
        {
            long score = 0;

            Line[] arr = LinesCounter.DiagLeft(gameProcess, flag);
            score += HeuristicLineHero(arr, gameProcess.N, first, flag);

            arr = LinesCounter.DiagRight(gameProcess, flag);
            score += HeuristicLineHero(arr, gameProcess.N, first, flag);

            arr = LinesCounter.HorLines(gameProcess, flag);
            score += HeuristicLineHero(arr, gameProcess.N, first, flag);

            arr = LinesCounter.VerLines(gameProcess, flag);
            score += HeuristicLineHero(arr, gameProcess.N, first, flag);

            if (flag == PlayerCell.Antagonist)
            {
                score = (-1) * score;
            }

            return score;
        }

        private static long heuristicAntagonist(FieldContext gameProcess, PlayerCell first, PlayerCell flag)
        {
            long score = 0;

            Line[] arr = LinesCounter.DiagLeft(gameProcess, flag);
            score += HeuristicLineAntagonist(arr, gameProcess.N, first, flag);

            arr = LinesCounter.DiagRight(gameProcess, flag);
            score += HeuristicLineAntagonist(arr, gameProcess.N, first, flag);

            arr = LinesCounter.HorLines(gameProcess, flag);
            score += HeuristicLineAntagonist(arr, gameProcess.N, first, flag);

            arr = LinesCounter.VerLines(gameProcess, flag);
            score += HeuristicLineAntagonist(arr, gameProcess.N, first, flag);

            if (flag == PlayerCell.Antagonist)//bot
            {
                score = (-1) * score;
            }

            return score;
        }
    }
}
