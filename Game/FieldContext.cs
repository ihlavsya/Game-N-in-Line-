using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class FieldContext
    {
        public PlayerCell[,] Field;
        public int[] FreePositions;
        public int QuanCols;
        public int QuanRows;
        public int N;

        public FieldContext(int n)
        {
            N = n;
            QuanCols = 2 * N;
            QuanRows = 2 * N - 1;

            Field = new PlayerCell[QuanRows, QuanCols];
            FreePositions = new int[QuanCols];
        }

        public void FillField(int col,PlayerCell a)
        {
            Field[FreePositions[col],col] =a;//не работает
            FreePositions[col]++;
        }

        private bool Overflow(PlayerCell [,]field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i,j] == PlayerCell.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int EndOfTheGame(PlayerCell flag)
        {
            Line[] arr1 = LinesCounter.HorLines(N, Field, flag);
            for (int i = 1; i < arr1[0].length; i++)
            {
                if (arr1[i].length >= N)
                {
                    return 1;
                }
            }
            Line[] arr2 = LinesCounter.VerLines(N, Field, flag);
            for (int i = 1; i < arr2[0].length; i++)
            {
                if (arr2[i].length >= N)
                {
                    return 1;
                }
            }
            Line[] arr3 = LinesCounter.DiagLeft(N, Field, flag);
            for (int i = 1; i < arr3[0].length; i++)
            {
                if (arr3[i].length >= N)
                {
                    return 1;
                }
            }
            Line[] arr4 = LinesCounter.DiagRight(N, Field, flag);
            for (int i = 1; i < arr4[0].length; i++)
            {
                if (arr4[i].length >= N)
                {
                    return 1;
                }
            }
            bool c = Overflow(Field);
            if (c)
            {
                return 0;
            }

            return -1;
        }

        public PlayerCell GetOppositePlayer(PlayerCell flag)
        {
            int a = ((int)flag % 2) + 1;
            return (PlayerCell)a;
        }
    }
}
