using System.Linq;

namespace Algorithms_and_Structures.SortingAlgorithms {
    public static class MergeSort {
        /// <summary>
        /// Time: O(n*log(n));
        /// Memory: зависит от задачи, может быть O(n);
        /// </summary>
        public static int[] Sort(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }

            var middle = array.Length / 2;
            return Merge(Sort(array.Take(middle).ToArray()), Sort(array.Skip(middle).ToArray()));
        }

        private static int[] Merge(int[] arr1, int[] arr2) {
            var ptr1 = 0;
            var ptr2 = 0;
            var merged = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < merged.Length; ++i)
            {
                if (ptr1 < arr1.Length && ptr2 < arr2.Length)
                {
                    merged[i] = arr1[ptr1] > arr2[ptr2] ? arr2[ptr2++] : arr1[ptr1++];
                }
                else
                {
                    merged[i] = ptr2 < arr2.Length ? arr2[ptr2++] : arr1[ptr1++];
                }
            }
		
            return merged;
        }
    }
}