namespace Algorithm.Sort
{
    /// <summary>
    /// 插入排序法
    /// 時間複雜度=> O(N平方)
    /// </summary>
    public class InsertionSort
    {
        public void Sort()
        {
            var array = Tool.GenerateRandomArray(30);

            Console.WriteLine(string.Join(',', array));
            for (int i = 1; i < array.Length; i++)
            {
                Tool.Insertion(array, i);
            }
            Console.WriteLine(string.Join(',', array));
        }
    }
}
