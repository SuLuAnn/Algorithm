namespace Algorithm.Sort
{
    /// <summary>
    /// 選擇排序法
    /// 時間複雜度=> (N-1)+...1 => N*(N-1)/2 => O(N平方)
    /// 效率差不實用
    /// </summary>
    public class SelectionSort
    {
        public void Sort()
        {
            var array = Tool.GenerateRandomArray(30);

            Console.WriteLine(string.Join(',', array));

            for (int i = 0; i < array.Length - 1; i++)
            {
                int tempIndex = i;
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k] < array[tempIndex])
                    {
                        tempIndex = k;
                    }
                }

                Tool.Swap(array, i, tempIndex);
            }

            Console.WriteLine(string.Join(',', array));
        }
    }
}
