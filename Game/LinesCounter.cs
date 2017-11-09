using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public struct Line
    {
        public int x_coor;
        public int y_coor;
        public int length;
    }

    public static class LinesCounter
    {
        public static Line EmptyLine;

        static LinesCounter()
        {
            EmptyLine.x_coor = 0;
            EmptyLine.y_coor = 0;
            EmptyLine.length = 0;
        }
    
        public static Line[] HorLines(int n, PlayerCell[,] field, PlayerCell flag)
        {
            Line[]ArrHor = new Line[(2 * n) * (2 * n - 1)];
            int N = 1;

            for (int i = 0; i < 2 * n - 1; i++)
            {
                Line a=EmptyLine;
                a.length = 0;
                a.x_coor = i;
                for (int j = 0; j < 2 * n; j++)
                {
                    PlayerCell d = field[i,j];
                    if (d == flag)
                    {
                        if (a.length == 0)
                        {
                            a.y_coor = j;
                        }
                        a.length++;
                    }

                    if ((d != flag || j == 2 * n - 1) && a.length != 0)
                    {
                        ArrHor[N++] = a;
                        a.length = 0;
                    }
                }
            }

            ArrHor[0].length = N;
            return ArrHor;
        }

        public static Line[] VerLines(int n, PlayerCell[,] field, PlayerCell flag)
        {
            Line[] ArrVer = new Line[(2 * n) * (2 * n - 1)];
            int N = 1;

            for (int j = 0; j < 2 * n; j++)
            {
                Line a = EmptyLine;
                a.length = 0;
                a.y_coor = j;
                for (int i = 0; i < 2 * n - 1; i++)
                {
                    PlayerCell d = field[i,j];
                    if (d == flag)
                    {
                        if (a.length == 0)
                        {
                            a.x_coor = i;
                        }
                        a.length++;
                    }

                    if ((d != flag || i == 2 * n - 2) && a.length != 0)
                    {
                        ArrVer[N++] = a;
                        a.length = 0;
                    }
                }
            }
            ArrVer[0].length = N;
            return ArrVer;
        }

        public static Line[] DiagRight(int n, PlayerCell[,] field, PlayerCell flag)
        {
            Line[] ArrDiag = new Line[(2 * n) * (2 * n - 1)];
            int N = 1;
            bool[,] check = new bool[2*n-1,2*n];

            for (int i = 0; i < 2 * n - 1; i++)
            {
                Line a = EmptyLine;
                a.length = 0;
                a.x_coor = i;
                for (int j = 0; j < 2 * n; j++)
                {
                    a.y_coor = j;
                    if (check[i,j] == false && field[i,j] == flag)
                    {
                        a.length = 0;
                        for (int k = 0; (k + j < 2 * n) && (k + i < 2 * n - 1); k++)
                        {
                            PlayerCell d = field[k + i,k + j];
                            if (d == flag)
                            {
                                a.length++;
                                check[k + i,k + j] = true;
                            }
                            if ((d != flag || i + k == 2 * n - 2 || j + k == 2 * n - 1) && a.length != 0)
                            {
                                ArrDiag[N++] = a;
                                a.length = 0;
                                break;
                            }
                        }
                    }
                }
            }
            ArrDiag[0].length = N;
            return ArrDiag;
        }

        public static Line[] DiagLeft(int n, PlayerCell[,] field, PlayerCell flag)
        {
            Line[] ArrDiag = new Line[(2 * n) * (2 * n - 1)];
            int N = 1;
            bool[,] check = new bool[2*n-1,2*n];

            for (int i = 2 * n - 2; i > -1; i--)
            {
                Line a = EmptyLine;
                a.length = 0;
                a.x_coor = i;
                for (int j = 0; j < 2 * n; j++)
                {
                    a.y_coor = j;
                    if (check[i,j] == false && field[i,j] == flag)
                    {
                        a.length = 0;
                        for (int k = 0; (k + j < 2 * n) && (i - k > -1); k++)
                        {
                            PlayerCell d = field[i - k,k + j];
                            if (d == flag)
                            {
                                a.length++;
                                check[i - k,k + j] = true;
                            }
                            if ((d != flag || i - k == 0 || j + k == 2 * n - 1) && a.length != 0)
                            {
                                ArrDiag[N++] = a;
                                a.length = 0;
                                break;
                            }
                        }
                    }
                }
            }
            ArrDiag[0].length = N;
            return ArrDiag;
        }
    }
}
