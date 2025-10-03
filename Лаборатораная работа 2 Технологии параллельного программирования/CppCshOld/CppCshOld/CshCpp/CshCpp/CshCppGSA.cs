using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CshCpp
{
    class CshCppGSA
    {
        CshCppWrp ap = new CshCppWrp();
        CshCppASMWRP asmp = new CshCppASMWRP();

        private float[] A;
        float res;

        public void Gen(int _l)
        {
            A = new float[_l];
            Random rnd = new Random();
            for (var i = 0; i < A.LongLength; i++)
            {
                A[i] = (float)0.000000001; //(float)rnd.Next(0, 2);
            }
        }

        /*public string SumCsh()
        {
            int i;
            
            if (null == A)
            {
                return @"Array not generated!";
            }
            else
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                res = 0;
                for (i = 0; i < A.LongLength; ++i)
                {
                    res = res + A[i];
                }
                timer.Stop();
                return string.Format(@"Sum:{0}; Time:{1}", res, timer.Elapsed);
            }
            
        }*/
        public string SumCsh()
        {
            if (A == null)
            {
                return @"Array not generated!";
            }
            else
            {
                // создаём второй массив той же длины
                float[] B = new float[A.Length]; // новая строка
                for (int i = 0; i < B.Length; i++) // новая строка
                    B[i] = 1.0f; // для примера заполняем единицами (можно любыми значениями)

                Stopwatch timer = new Stopwatch();
                timer.Start();

                // складываем элементы двух массивов: A = A + B
                for (int i = 0; i < A.Length; i++) // изменено: теперь A[i] += B[i]
                {
                    A[i] = A[i] + B[i]; // изменено
                }

                // теперь пример с матрицами: создаём квадратные матрицы размером sqrt(A.Length)
                int n = (int)Math.Sqrt(A.Length); // новая строка
                if (n * n == A.Length && n % 4 == 0) // новая строка: проверка кратности 4
                {
                    float[,] M1 = new float[n, n]; // новая строка
                    float[,] M2 = new float[n, n]; // новая строка
                                                   // заполняем матрицы
                    for (int r = 0; r < n; r++) // новая строка
                        for (int c = 0; c < n; c++) // новая строка
                        {
                            M1[r, c] = 1.0f; // новая строка
                            M2[r, c] = 2.0f; // новая строка
                        }
                    // складываем матрицы: M1 = M1 + M2
                    for (int r = 0; r < n; r++) // новая строка
                        for (int c = 0; c < n; c++) // новая строка
                        {
                            M1[r, c] = M1[r, c] + M2[r, c]; // новая строка
                        }
                }

                timer.Stop();
                return string.Format(@"Arrays and matrices summed; Time:{0}", timer.Elapsed); // изменено: новый текст
            }
        }

        public string SumCppDLL()
        {
            if (A == null)
            {
                 return @"Array not generated!";
            }
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                res = ap.Sum(A);
                timer.Stop();
                return string.Format(@"Sum:{0}; Time:{1}", res, timer.Elapsed);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string SumCppDLLasm()
        {
            if (A == null)
            {
                return @"Array not generated!";
            }
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                res = asmp.Sum(A);
                timer.Stop();
                return string.Format(@"Sum:{0}; Time:{1}", res, timer.Elapsed);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
