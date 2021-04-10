namespace Codility.MaximumSliceProblem.MaxProfit
{
    public class Algorithm
    {
        public int SolutionBad(int[] a)
        {
            int maxProfit = 0;

            for (var i = 0; i < a.Length; i++)
            {
                for (var j = i + 1; j < a.Length; j++)
                {
                    var profit = a[j] - a[i];
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }

            return maxProfit;
        }

        public int Solution(int[] a)
        {
            int sliceProfit = 0;
            int maxProfit = 0; 

            for(var i = 0; i < a.Length - 1; i++)
            {
                var currentProfit = a[i + 1] - a[i];
                if(sliceProfit + currentProfit > 0)
                {
                    sliceProfit = sliceProfit + currentProfit;
                }
                else
                {
                    sliceProfit = 0;
                }

                if(sliceProfit > maxProfit)
                {
                    maxProfit = sliceProfit;
                }
            }
            return maxProfit;
        }
    }
}
