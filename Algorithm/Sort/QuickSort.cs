namespace Algorithm.Sort
{
    /// <summary>
    /// 前序走訪
    /// </summary>
    public class QuickSort
    {
        public void Sort()
        {
            var array = Tool.GenerateRandomArray(5);

            Console.WriteLine(string.Join(',', array));

            Quicksort(array, 0, array.Length - 1);

            Console.WriteLine(string.Join(',', array));
        }

        private void Quicksort(int[] array, int l, int r)
        {
            if (l < r)
            {
                int m = Tool.Partition(array, l, r);
                Quicksort(array, l, m - 1);
                Quicksort(array, m + 1, r);
            }
        }
    }
}
