namespace Algorithm
{
    public static class Tool
    {
        /// <summary>
        /// 產生 random array
        /// </summary>
        /// <param name="count">array 長度</param>
        /// <returns></returns>
        public static int[] GenerateRandomArray(int count)
        {
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = Random.Shared.Next(1000);
            }

            return array;
        }

        /// <summary>
        /// 互換
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        public static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        /// <summary>
        /// 將 array 第 i 元素 插入 已升冪排序的 [0, i)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="i"></param>
        public static void Insertion(int[] array, int i)
        {
            int temp = array[i];
            for (int k = i - 1; k >= 0; k--)
            {
                if (temp < array[k])
                {
                    array[k + 1] = array[k];
                }
                else
                {
                    array[k + 1] = temp;
                    return;
                }
            }
            // 如果到結束 temp 都沒放進去，代表 temp 是最小的，放第一個
            array[0] = temp;
        }

        /// <summary>
        /// 分割
        /// </summary>
        /// <param name="array"></param>
        /// <param name="l">最左邊的 index</param>
        /// <param name="r">最右邊的 index, 分割基準數</param>
        public static void Partition(int[] array, int l, int r)
        {
            int edge = 0;
            for (int i = l; i < r; i++)
            {
                if (array[i] < array[r])
                {
                    Swap(array, i, edge);
                    edge++;
                }
            }

            Swap(array, edge, r);
        }
    }
}
