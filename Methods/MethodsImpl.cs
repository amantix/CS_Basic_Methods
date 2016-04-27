namespace Methods
{
    /// <summary>
    /// Класс, содержащий методы, которые необходимо реализовать
    /// </summary>
    public static class MethodsImpl
    {
        /// <summary>
        /// Метод вычисления наибольшего общего делителя
        /// </summary>
        /// <param name="x">первое число</param>
        /// <param name="y">второе число</param>
        /// <returns>значение НОД</returns>
        public static int GCD(int x, int y)
        {
            if (x != 0 && y != 0)
            {
                while (y != 0)
                {
                    int tmp = x % y;
                    x = y;
                    y = tmp;
                }
                return System.Math.Abs(x);
            }
            else
                if ((x != 0 && y == 0) || (x == 0 && y != 0))
                return 1;
            else
                throw new System.Exception("Наибольший общий делитель существует и однозначно определён, если хотя бы одно из чисел не равно нулю!");
            //throw new System.NotImplementedException();
        }

        /// <summary>
        /// Метод вычисления наименьшего общего кратного
        /// </summary>
        /// <param name="x">первое число</param>
        /// <param name="y">второе число</param>
        /// <returns>значение НОК</returns>
        public static int LCM(int x, int y)
        {
            double res = System.Math.Abs(((double)x * (double)y)) / GCD(x, y);
            return (int)res;
            //throw new System.NotImplementedException();
        }

        /// <summary>
        /// Метод вычисления НОК всех элементов массива
        /// </summary>
        /// <param name="array">массив элементов</param>
        /// <returns>НОК всех элементов массива</returns>
        public static int LCM(int[] array)
        {
            int lcm = LCM(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
            {
                lcm = LCM(lcm, array[i]);
            }
            return lcm;
            //throw new System.NotImplementedException();
        }

        /// <summary>
        /// Метод заполнения матрицы по спирали
        /// Пример:
        /// 1   2   3   4
        /// 10  11  12  5
        /// 9   8   7   6
        /// </summary>
        /// <param name="matrix">Матрица, которую нужно заполнить</param>
        public static void SpiralFill(int[,] matrix)
        {
            int counter = 1;
            int l = 0;
            int r = matrix.GetLength(1) - 1;
            int u = 0;
            int d = matrix.GetLength(0) - 1;

            while (l <= r && d >= u)
            {
                for (int j = l; j <= r; j++)
                    matrix[u, j] = counter++;
                for (int i = u + 1; i <= d; i++)
                    matrix[i, r] = counter++;
                if (u != d)
                    for (int j = r - 1; j >= l; j--)
                        matrix[d, j] = counter++;
                if (l != r)
                    for (int i = d - 1; i > u; i--)
                        matrix[i, l] = counter++;
                r--;
                l++;
                u++;
                d--;
            }
            //throw new System.NotImplementedException();
        }

        /// <summary>
        /// Метод заполнения матрицы,
        /// заданной в виде ступенчатого массива
        /// по спирали
        /// </summary>
        /// <param name="x">матрица, которую нужно заполнить</param>
        public static void SpiralFill(int[][] x)
        {
            int tmp = 0;
            int counter = 1;
            int l = 0;
            int r = x[tmp].Length - 1;
            int u = 0;
            int d = x.Length - 1;

            while (l <= r && d >= u)
            {
                for (int j = l; j <= r; j++)
                    x[u][j] = counter++;
                for (int i = u + 1; i <= d; i++)
                    x[i][r] = counter++;
                if (u != d)
                    for (int j = r - 1; j >= l; j--)
                        x[d][j] = counter++;
                if (l != r)
                    for (int i = d - 1; i > u; i--)
                        x[i][l] = counter++;
                r--;
                l++;
                u++;
                d--;
            }
            //throw new System.NotImplementedException();
        }

        /// <summary>
        /// Метод для вывода матрицы в консоль
        /// </summary>
        /// <param name="matrix">матрица, которую нужно вывести</param>
        public static void PrintMatrix(int[,] matrix)
        {
            for (int i=0; i<matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    System.Console.Write(matrix[i,j]+" ");
                System.Console.WriteLine();
            }
            //throw new System.NotImplementedException();
        }

        /// <summary>
        /// Метод для вывода матрицы в консоль
        /// Матрица задается в виде ступенчатого массива
        /// </summary>
        /// <param name="matrix">матрица, которую нужно вывести</param>
        public static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                    System.Console.Write(matrix[i][j] + " ");
                System.Console.WriteLine();
            }
            //throw new System.NotImplementedException();
        }


        /// <summary>
        /// Эта функция находит минимальное значение в строке матрицы
        /// </summary>
        /// <param name="array_row">Матрица, минимальное значение строки которой нужно найти</param>
        /// <param name="i">Номер строки, минимальное значение которой нужно найти</param>
        /// <returns></returns>
        public static int MinValueInRow(int[,] array_row, int i)
        {
            int min = array_row[i, 0];

            for (int j = 0; j < array_row.GetLength(1); j++)
                if (array_row[i, j] < min)
                    min = array_row[i, j];

            return min;
        }

        /// <summary>
        /// Эта функция находит максимальное значение в столбце матрицы
        /// </summary>
        /// <param name="array_row">Матрица, максимальное значение столбца которого нужно найти</param>
        ///  <param name="j">Номер столбца, максимальное значение которого нужно найти</param>
        /// <returns></returns>
        public static int MaxValueInColumn(int[,] array_row, int j)
        {
            int max = array_row[0, j];

            for (int i = 0; i < array_row.GetLength(0); i++)
                if (array_row[i, j] > max)
                    max = array_row[i, j];

            return max;
        }

        /// <summary>
        /// Эта функция находит минимальные значения в каждой строке
        /// </summary>
        /// <param name="matrix">Эта матрица, минимальные значения строк которой нужно найти</param>
        /// <returns>Возвращается true - если элемент минимальный в строке, иначе - false</returns>
        public static bool[,] MinInRow(int[,] matrix)
        {
            bool[,] min_in_row = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < min_in_row.GetLength(0); i++)
            {
                int min = MinValueInRow(matrix, i);

                for (int j = 0; j < min_in_row.GetLength(1); j++)
                {
                    if (matrix[i, j] == min)
                    {
                        min_in_row[i, j] = true;
                    }
                    else
                        min_in_row[i, j] = false;
                }
            }

            return min_in_row;
        }

        /// <summary>
        /// Эта функция находит максимальные значения в каждом столбце
        /// </summary>
        /// <param name="matrix">Эта матрица, максимальные значения столбца которой нужно найти</param>
        /// <returns>Возвращается true - если элемент максимальный в строке, иначе - false</returns>
        public static bool[,] MaxInColumn(int[,] matrix)
        {
            bool[,] max_in_column = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for (int j = 0; j < max_in_column.GetLength(1); j++)
            {
                int max = MaxValueInColumn(matrix, j);

                for (int i = 0; i < max_in_column.GetLength(0); i++)
                {
                    if (matrix[i, j] == max)
                    {
                        max_in_column[i, j] = true;
                    }
                    else
                        max_in_column[i, j] = false;
                }
            }

            return max_in_column;
        }
        /// <summary>
        /// Печать информации о седловых точках матрицы
        /// В формате значение(строка,столбец)
        /// Если в матрице две седловые точки со значениями 3,
        /// в позициях 1,0 и 2,1, то метод должен печатать в консоль
        /// 3(1,0) 3(2,1)
        /// </summary>
        /// <param name="matrix">Матрица, в которой ищутся седловые точки</param>
        public static void PrintSaddlePoints(int[,] matrix)
        {
            bool[,] min = MinInRow(matrix);
            bool[,] max = MaxInColumn(matrix);
            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (min[i, j] == true && max[i, j] == true)
                        result += matrix[i, j] + "(" + i + "," + j + ")"+" ";
            }

            if (result != "")
                System.Console.Write(result);
            else
                System.Console.WriteLine("Данная матрица не имеет седловых точек");
            //throw new System.NotImplementedException();
        }


        public static int MinValueInRow(int[][] array_row, int i)
        {
            int min = array_row[i][0];

            for (int j = 0; j < array_row[i].Length; j++)
                if (array_row[i][j] < min)
                    min = array_row[i][j];

            return min;
        }
        public static int MaxValueInColumn(int[][] array_row, int j)
        {
            int max = array_row[0][j];

            for (int i = 0; i < array_row.Length; i++)
                if (array_row[i][j] > max)
                    max = array_row[i][j];

            return max;
        }
        public static bool[][] MinInRow(int[][] matrix)
        {
            bool[][] min_in_row = new bool[matrix.Length][];

            for (int i = 0; i < matrix.Length; i++)
                min_in_row[i] = new bool[matrix[i].Length];


            for (int i = 0; i < min_in_row.Length; i++)
            {
                int min = MinValueInRow(matrix, i);

                for (int j = 0; j < min_in_row[i].Length; j++)
                {
                    if (matrix[i][j] == min)
                    {
                        min_in_row[i][j] = true;
                    }
                    else
                        min_in_row[i][j] = false;
                }
            }

            return min_in_row;
        }
        public static bool[][] MaxInColumn(int[][] matrix)
        {
            bool[][] max_in_column = new bool[matrix.Length][];

            for (int i = 0; i < matrix.Length; i++)
                max_in_column[i] = new bool[matrix[i].Length];
            int tmp = 0;
            for (int j = 0; j < max_in_column[tmp].Length; j++)
            {
                int max = MaxValueInColumn(matrix, j);

                for (int i = 0; i < max_in_column.Length; i++)
                {
                    if (matrix[i][j] == max)
                    {
                        max_in_column[i][j] = true;
                    }
                    else
                        max_in_column[i][j] = false;
                }
                if (tmp < max_in_column.Length - 1)
                    tmp++;
            }
            return max_in_column;
        }


        /// <summary>
        /// Печать информации о седловых точках матрицы
        /// В формате значение(строка,столбец)
        /// Если в матрице две седловые точки со значениями 3,
        /// в позициях 1,0 и 2,1, то метод должен печатать в консоль
        /// 3(1,0) 3(2,1)
        /// </summary>
        /// <param name="matrix">Матрица, в которой ищутся седловые точки</param>
        public static void PrintSaddlePoints(int[][] matrix)
        {
            bool[][] min = MinInRow(matrix);
            bool[][] max = MaxInColumn(matrix);
            string result = "";
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                    if (min[i][j] == true && max[i][j] == true)
                        result += matrix[i][j] + "(" + i + "," + j + ")" + " ";
            }

            if (result != "")
                System.Console.Write(result);
            else
                System.Console.WriteLine("Данная матрица не имеет седловых точек");
            //throw new System.NotImplementedException();
        }

        static int Step1(int x)
        {
            string string_x = x.ToString();
            string tmp = "";
            for (int i = 0; i < string_x.Length; i++)
            {
                int s = 0;
                if (i % 2 == 0)
                    s = System.Int32.Parse(string_x[i].ToString()) * 2;
                else
                    s = System.Int32.Parse(string_x[i].ToString());
                if (s > 10)
                    tmp += s / 10 + s % 10;
                else
                    tmp += s;
            }
            int result = System.Int32.Parse(tmp);
            return result;
        }

        static int Step2(int x)
        {
            string string_x = x.ToString();
            int s = 0;
            for (int i = 0; i < string_x.Length; i++)
                s += System.Int32.Parse(string_x[i].ToString());

            return s;
        }

        /// <summary>
        /// Функция вычисления контрольной суммы числа
        /// Сперва чередуясь умножим цифры на 2, 
        /// в случае получения чисел > 10, скложим цифры.
        /// Затем сложим цифры результата.
        /// Возвратим 10 - сумма_цифр%10
        /// </summary>
        /// <param name="number">Целое число</param>
        /// <returns>Значение контрольной суммы</returns>
        public static int CheckSum(int number)
        {
            return (10 - Step2(Step1(number)) % 10);
            //throw new System.NotImplementedException();
        }

    }

    
}
