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
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Метод вычисления наименьшего общего кратного
        /// </summary>
        /// <param name="x">первое число</param>
        /// <param name="y">второе число</param>
        /// <returns>значение НОК</returns>
        public static int LCM(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Метод вычисления НОК всех элементов массива
        /// </summary>
        /// <param name="array">массив элементов</param>
        /// <returns>НОК всех элементов массива</returns>
        public static int LCM(int[] array)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Метод заполнения матрицы,
        /// заданной в виде ступенчатого массива
        /// по спирали
        /// </summary>
        /// <param name="x">матрица, которую нужно заполнить</param>
        public static void SpiralFill(int[][] x)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Метод для вывода матрицы в консоль
        /// </summary>
        /// <param name="matrix">матрица, которую нужно вывести</param>
        public static void PrintMatrix(int[,] matrix)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Метод для вывода матрицы в консоль
        /// Матрица задается в виде ступенчатого массива
        /// </summary>
        /// <param name="matrix">матрица, которую нужно вывести</param>
        public static void PrintMatrix(int[][] matrix)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

    }

    
}
