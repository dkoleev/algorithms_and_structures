namespace Algorithms_and_Structures.SortingAlgorithms {

    public static class BubbleSort {
        /// <summary>
        /// Time: O(n^2);
        /// Memory: O(1);
        /// </summary>
        public static int[] Sort(int[] array) {
            for (int i = 0; i < array.Length; i++) {
                for (int j = 0; j < array.Length - 1 - i; j++) {
                    if (array[j] > array[j + 1]) {
                        Swap(ref array[j], ref array[j+1]);
                    }
                }
            }

            return array;
        }

        private static void Swap(ref int a, ref int b) {
            var temp = b;
            b = a;
            a = temp;
        }
    }
}
