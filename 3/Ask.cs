using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task._3
{
    static class Ask
    {
        /// <summary>
        /// <para> Отсчитать несколько элементов с конца </para>
        /// <example> new[] {1,2,3,4}.EnumerateFromTail(2) = (1, ), (2, ), (3, 1), (4, 0)</example>
        /// </summary> 
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <param name="tailLength">Сколько элеметнов отсчитать с конца  (у последнего элемента tail = 0)</param>
        /// <returns></returns>
        public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength) 
        {
            if (tailLength == null || tailLength <= 0)
            {
                return new List<(T item, int? tail)>();
            }
            var count = enumerable.Count();
            var items = new List<(T item, int? tail)>();

            if (tailLength >= count) 
            {
                foreach (var item in enumerable) 
                {
                    items.Add((item, --count));
                }
            }
            else 
            {
                var i = 0;
                var startCount = count - tailLength;
                foreach(var item in enumerable) 
                {
                    items.Add((item, i >= startCount ? --tailLength : null));
                    i++;
                }
            } 

            return items;
        }

    }
}
