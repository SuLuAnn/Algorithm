namespace Algorithm.GreatestCommonDivisor
{
    /// <summary>
    /// 輾轉相除法(歐幾里得演算法)
    /// 原理: a, b(a > b) 最大公因數等於 b, (a % b) 的最大公因數
    /// 時間複雜度: 2log(b) => O(log b)
    /// 最小公倍: a*b/最大公因(a, b)
    /// </summary>
    public class EuclideanAlgo
    {
        public void GetGreatestCommonDivisor(int a, int b)
        {
            int large;
            int small;
            if (a > b)
            {
                large = a;
                small = b;
            }
            else
            {
                large = b;
                small = a;
            }

            int r = int.MaxValue;

            while (r != 0)
            {
                r = large % small;
                large = small;
                small = r;
            }

            Console.WriteLine(large);
        }
    }
}
