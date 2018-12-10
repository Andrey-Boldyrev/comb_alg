using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace std
{
    //жадный алгоритм
    class GreedAlgorithm
    {
        public static List<StringBuilder> FindRes(int[] sizes, int capacity, out long time)
        {
            //время выполнения
            time = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            //ответ
            List<StringBuilder> res = new List<StringBuilder>(20);

            //для хранения суммы на каждой дискете
            List<int> disks = new List<int>(1);
            
            //сортируем размеры по убыванию 
            Array.Sort(sizes);
            Array.Reverse(sizes);

            //проверяем есть ли размеры больше размера дискеты
            if (sizes[0] > capacity)
            {
                return null;
            }

            //двумерный массив, который будет показывать использовался ли элемент
            int[,] checkSizes = new int[2, sizes.Length];

            for (int i = 0; i < sizes.Length; i++)
            {
                checkSizes[0, i] = sizes[i];
            }

            for (int i= 0; i< sizes.Length; i++)
            {
                //смотрим куда можно положить
                for (int j = 0; j < disks.Count; j++)
                {
                    //если нашли куда положить
                    if (disks[j] + checkSizes[0, i] <= capacity)
                    {
                        disks[j] += checkSizes[0, i];
                        res[j].Append(checkSizes[0, i].ToString() + ' ');
                        checkSizes[1, i] = 1;
                        break;
                    }
                }
                //если не нашли куда положить
                if (checkSizes[1, i] == 0)
                {
                    StringBuilder sb = new StringBuilder(checkSizes[0, i].ToString() + ' ');
              
                    disks.Add(checkSizes[0, i]);
                    res.Add(sb);
                    checkSizes[1, i] = 1;
                }
            }

            stopWatch.Stop();
            time = stopWatch.ElapsedTicks;
            return res;
        }
    }
}