using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Methods.MethodsImpl;

namespace MethodTests
{
    /// <summary>
    /// Тестовый класс, содержащий тесты
    /// для методов, которые требуется реализовать
    /// в домашнем задании
    /// </summary>
    [TestClass]
    public class MethodsTests
    {
        /// <summary>
        /// Тест для метода, вычисляющего НОД
        /// </summary>
        [TestMethod]
        public void GCDTests()
        {
            Assert.AreEqual(1, GCD(0, 5));
            Assert.AreEqual(14, GCD(28, 98));
        }

        /// <summary>
        /// Тест для методов, вычисляющих НОК
        /// </summary>
        [TestMethod]
        public void LCMTests()
        {
            Assert.AreEqual(232792560,
                LCM(new int[]
                {
                    1, 2, 3, 4, 5,
                    6, 7, 8, 9, 10,
                    11, 12, 13, 14, 15,
                    16, 17, 18, 19, 20
                }));

            Assert.AreEqual(196, LCM(28, 98));
        }

        /// <summary>
        /// Тест для метода, заполняющего матрицу по спирали
        /// </summary>
        [TestMethod]
        public void SpiralFillTests()
        {
            int[,] m = new int[1, 1];
            SpiralFill(m);
            int[,] id = new int[1, 1] { { 1}};
            CollectionAssert.AreEqual(m, id);
            m = new int[1, 2];
            SpiralFill(m);
            id = new int[1, 2] {{1, 2}};
            CollectionAssert.AreEqual(m, id);
            m = new int[3, 1];
            SpiralFill(m);
            id = new int[3, 1] {{1}, {2}, {3}};
            CollectionAssert.AreEqual(m, id);
            m = new int[3,5];
            SpiralFill(m);
            id = new int[3, 5]
            {
                {1,2,3,4,5 }, {12,13,14,15,6 }, {11,10,9,8,7 }
            };

            CollectionAssert.AreEqual(m, id);
        }

        /// <summary>
        /// Тест для метода, заполняющего матрицу
        /// (заданную в виде ступенчатого массива)
        /// по спирали
        /// </summary>
        [TestMethod]
        public void SpiralFillJATests()
        {
            int[][] m = new int[1][];
            m[0] = new int[1];
            SpiralFill(m);
            int[][] id = new int[1][] { new int[]{ 1  }};
            CollectionAssert.AreEqual(m[0], id[0]);

            m = new int[1][];
            m[0] = new int[2];
            SpiralFill(m);
            id = new int[1][] {new int[2] { 1, 2 } };
            CollectionAssert.AreEqual(m[0], id[0]);

            
            m = new int[3][];
            for (int i = 0; i < 3; i++)
                m[i] = new int[1];
            SpiralFill(m);
            id = new int[3][] { new int[]{ 1 }, new int[]{ 2 }, new int[]{ 3 } };
            for(int i=0; i<3; i++)
            CollectionAssert.AreEqual(m[i], id[i]);

            m = new int[3][];
            for (int i = 0; i < 3; i++)
                m[i] = new int[5];
            SpiralFill(m);
            id = new int[3][]
            {
                new int[]{1,2,3,4,5 }, new int[]{12,13,14,15,6 }, new int[]{11,10,9,8,7 }
            };
            for(int i=0; i<3; i++)
            CollectionAssert.AreEqual(m[i], id[i]);
        }

        /// <summary>
        /// Тест для метода, вычисляющего контрольную сумму числа
        /// </summary>
        [TestMethod]
        public void CheckSumTest()
        {
            Assert.AreEqual(5, CheckSum(111));
            Assert.AreEqual(3, CheckSum(876));
            Assert.AreEqual(10, CheckSum(5));
            Assert.AreEqual(9, CheckSum(515));
        }

        /// <summary>
        /// Тест для метода, выводящего в консоль
        /// информацию обо всех седловых точках матрицы
        /// </summary>
        [TestMethod]
        public void SaddlePointsTest()
        {
            var sr = new System.IO.StringWriter();
            System.Console.SetOut(sr);
            int[,] x = new int[1, 1] {{1}};
            PrintSaddlePoints(x);
            var result = sr.ToString().Split(new char[] {' '},System.StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(result, new string[] {"1(0,0)"});
            sr.GetStringBuilder().Clear();

            x = new int[2, 2] { { 2,3 }, {1,2} };
            PrintSaddlePoints(x);
            result = sr.ToString().Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(result, new string[] { "2(0,0)" });
            sr.GetStringBuilder().Clear();

            x = new int[3, 3] { { 3,4,3}, { 3,2,1}, { 2,5,2}};
            PrintSaddlePoints(x);
            result = sr.ToString().Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(result, new string[] { "3(0,0)","3(0,2)" });
        }

        /// <summary>
        /// Тест для метода, выводящего в консоль
        /// информацию обо всех седловых точках матрицы,
        /// заданной в виде ступенчатого массива
        /// </summary>
        [TestMethod]
        public void SaddlePointsJATest()
        {
            var sr = new System.IO.StringWriter();
            System.Console.SetOut(sr);
            int[][] x = new int[1][] { new int[]{ 1 } };
            PrintSaddlePoints(x);
            var result = sr.ToString().Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(result, new string[] { "1(0,0)" });
            sr.GetStringBuilder().Clear();

            x = new int[2][] { new int[]{ 2, 3 }, new int[]{ 1, 2 } };
            PrintSaddlePoints(x);
            result = sr.ToString().Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(result, new string[] { "2(0,0)" });
            sr.GetStringBuilder().Clear();

            x = new int[3][] { new int[]{ 3, 4, 3 }, new int[]{ 3, 2, 1 }, new int[]{ 2, 5, 2 } };
            PrintSaddlePoints(x);
            result = sr.ToString().Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            CollectionAssert.AreEqual(result, new string[] { "3(0,0)", "3(0,2)" });
        }
    }


}

