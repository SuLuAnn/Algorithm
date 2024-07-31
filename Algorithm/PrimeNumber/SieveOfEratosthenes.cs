namespace Algorithm.PrimeNumber
{
    /// <summary>
    /// 埃拉托斯特尼篩法
    /// 質數演算法
    /// 時間複雜度: O(N loglog N)
    /// </summary>
    public class SieveOfEratosthenes
    {
        public void GetPrime()
        {
            // 求 2~49 的質數
            bool[] array = new bool[50];
            Array.Fill(array, true, 2, 48);
            for (int i = 2; i < array.Length; i++)
            {
                if (!array[i])
                {
                    continue;
                }
                for (int k = 2; k < array.Length; k++)
                {
                    int temp = i * k;
                    if (temp >= array.Length)
                    {
                        break;
                    }
                    array[temp] = false;
                }
            }

            Console.WriteLine(string.Join(',', array.Select((isExist, index) => (isExist, index)).Where(x => x.isExist).Select(x => x.index)));
        }
    }
}
