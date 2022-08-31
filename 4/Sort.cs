using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task._4
{
    class SortTask
    {
        /// <summary>
        /// Возвращает отсортированный по возрастанию поток чисел
        /// </summary>
        /// <param name="inputStream">Поток чисел от 0 до maxValue. Длина потока не превышает миллиарда чисел.</param>
        /// <param name="sortFactor">Фактор упорядоченности потока. Неотрицательное число. Если в потоке встретилось число x, то в нём больше не встретятся числа меньше, чем (x - sortFactor).</param>
        /// <param name="maxValue">Максимально возможное значение чисел в потоке. Неотрицательное число, не превышающее 2000.</param>
        /// <returns>Отсортированный по возрастанию поток чисел.</returns>
        public static IEnumerable<int> Sort(IEnumerable<int> inputStream, int sortFactor, int maxValue) 
        { 
            var sortList = new List<int>();
            var maxNumber = inputStream.Max();
            if (maxValue > 2000 && maxValue < 0 && maxValue > inputStream.Count()) 
            {
                return sortList;
            }
            sortList = inputStream.OrderBy(x => x).SkipWhile(x => x < maxNumber - sortFactor).ToList();

            return sortList;
            //На сортировку потребовалось 12ms и потребление памяти возросло по сравнению с 19 строкой на 9,30 KB
        }

    }
}
