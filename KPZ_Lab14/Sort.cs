using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_Lab14
{
    public class Sort
    {
        
        private void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        private int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                {
                    result = i;
                }
            }

            return result;
        }

        public async Task<int[]> BubbleSortAsync(int[] mass)
        {
            return await Task.Run(() => BubbleSort(mass));
        }

        public async Task<int[]> SelectionSortAsync(int[] mass)
        {
            return await Task.Run(() => SelectionSort(mass));
        }

        public async Task<int[]> InsertionSortAsync(int[] mass)
        {
            return await Task.Run(() => InsertionSort(mass));
        }

        public int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }

        public int[] SelectionSort(int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;

            var index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }

            return SelectionSort(array, currentIndex + 1);
        }
        public int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }

            return array;
        }
    }
}
