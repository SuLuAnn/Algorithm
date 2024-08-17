namespace Algorithm.Sort
{
    /// <summary>
    /// 時間複雜度: N log N
    /// 外部排序
    /// 穩定排序
    /// 後序走訪
    /// </summary>
    public class MergeSort
    {
        public void Sort()
        {
            var array = Tool.GenerateRandomArray(30);

            Console.WriteLine(string.Join(',', array));

            Mergesort(array, 0, array.Length);

            Console.WriteLine(string.Join(',', array));
        }

        /// <summary>
        /// 針對 [l, r) 區間合併排序
        /// </summary>
        /// <param name="array"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        private void Mergesort(int[] array, int l, int r)
        {
            if (l + 1 < r)
            {
                int m = (l + r) / 2;
                Mergesort(array, l, m);
                Mergesort(array, m, r);
                Tool.Merge(array, l, m, r);
            }
        }
    }
}
