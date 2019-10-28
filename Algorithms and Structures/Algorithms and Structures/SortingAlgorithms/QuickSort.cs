namespace Algorithms_and_Structures.SortingAlgorithms {
    public static class QuickSort {
        /// <summary>
        /// Time: middle - O(n*log(n)), baddest - O(n^2);
        /// Memory: O(log(n));
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] Sort(int[] array)
        {
            return Sort(array, 0, array.Length - 1);
        }
        
        private static int[] Sort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            Sort(array, minIndex, pivotIndex - 1);
            Sort(array, pivotIndex + 1, maxIndex);

            return array;
        } 

        private static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        
        private static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
    }
}