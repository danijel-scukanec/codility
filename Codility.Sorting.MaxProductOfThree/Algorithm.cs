using System;

namespace Codility.Sorting.MaxProductOfThree
{
    public class Algorithm
    {
        public int Solution(int[] a)
        {
            Array.Sort(a);

            int maxProduct = a[a.Length - 1] * a[a.Length - 2] * a[a.Length - 3];          

            if(a[0] < 0 && a[1] < 0)
            {
                var tempResult = a[0] * a[1] * a[a.Length - 1];
                if(tempResult > maxProduct)
                {
                    maxProduct = tempResult;
                }
            }                            

            Console.WriteLine($"Max product for array {string.Join(',', a)} is {maxProduct}");
            return maxProduct;
        }
    }
}
