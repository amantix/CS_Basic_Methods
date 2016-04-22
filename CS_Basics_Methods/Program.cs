using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void PrintMatrix(int[,]x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                    Console.Write(x[i, j] + "\t");
                Console.WriteLine();
            }
        }

        static void FillSpiral(int[,]x)
        {
            int counter = 1;
            int l = 0, r = x.GetLength(1) - 1, u = 0, d = x.GetLength(0) - 1;
            while (l <= r && d >= u)
            {
                for (int j = l; j <= r; j++)
                    x[u, j] = counter++;
                for (int i = u + 1; i <= d; i++)
                    x[i, r] = counter++;
                if(u!=d)
                for (int j = r - 1; j >= l; j--)
                    x[d, j] = counter++;
                if(l!= r)
                for (int i = d - 1; i > u; i--)
                    x[i, l] = counter++;
                r--;
                l++;
                u++;
                d--;
            }//while
        }//FillSpiral

        static void PrintDiag(int[,]x,int diag)
        {
            int i, j;
            if(diag<x.GetLength(0))
            {
                j = 0;
                i = diag;
            }
            else
            {
                i = x.GetLength(0)-1;
                j = diag - x.GetLength(0) + 1;
            }
            while (i >= 0 && j < x.GetLength(1))
                Console.Write(x[i--,j++]+" ");
        }

        static void PrintDiagRev(int[,]x,int diag)
        {
            int i, j;
            if(diag<x.GetLength(1))
            {
                i = 0;
                j = diag;
            }
            else
            {
                i = diag - x.GetLength(1) + 1;
                j = x.GetLength(1) - 1;
            }
            while (i < x.GetLength(0) && j >= 0)
                Console.Write(x[i++, j--]+" ");
        }

        static void PrintSnake(int[,]x)
        {
            for (int k = 0; k < x.GetLength(0) + x.GetLength(1); k++)
                if (k%2 == 0)
                    PrintDiag(x, k);
                else 
                    PrintDiagRev(x, k);
        }

        static void Main(string[] args)
        {
            int[,] x = new int[4, 5];

            //FillSpiral(x);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 5; j++)
                    x[i,j] = 5 * i + j+1;

            PrintMatrix(x);
            Console.WriteLine();
            //
            PrintSnake(x);

        }//Main
    }//Program
}//Methods
