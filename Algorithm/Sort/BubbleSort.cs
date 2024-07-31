namespace Algorithm.Sort
{
    /// <summary>
    /// 氣泡排序法
    /// 時間複雜度=> (N-1)+...1 => N*(N-1)/2 => O(N平方)
    /// 效率差不實用
    /// </summary>
    public class BubbleSort
    {
        public void Sort()
        {
            var array = Tool.GenerateRandomArray(30);

            Console.WriteLine(string.Join(',', array));
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int k = array.Length - 1; k > i; k--)
                {
                    if (array[k] < array[k - 1])
                    {
                        Tool.Swap(array, k, k - 1);
                    }
                }
            }
            Console.WriteLine(string.Join(',', array));
        }
    }
}
