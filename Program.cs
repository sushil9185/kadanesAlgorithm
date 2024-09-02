namespace kadanesAlgorithm
{
    internal class Program
    {
        //Given an integer array arr, find the contiguous subarray
        //(containing at least one number) which
        //has the largest sum and returns its sum and prints the subarray.
        static void Main(string[] args)
        {
            int[] myArray = { -2, -3, 4, -1, -2, 1, 5, -3 };
            Console.WriteLine(FindMaxSubArray2(myArray));
        }

        //optimal
        static int FindMaxSubArray2(int[] nums)
        {
            int sum = 0, maxSum = int.MinValue, start = 0, startIndex = -1, endIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                //To find the index
                if(sum == 0)
                    start = i;

                sum += nums[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    //To find the index
                    startIndex = start;
                    endIndex = i;
                }
                if (sum < 0)
                    sum = 0;
            }
            return maxSum;
        }

        //better
        static int FindMaxSubArray1(int[] nums)
        {
            int n = nums.Length, maxSum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for(int j = i; j <n; j++)
                {
                    sum += nums[j];
                    maxSum = Math.Max(maxSum, sum);
                }
                //maxSum = Math.Max(maxSum, sum);
            }
            return maxSum;
        }

        //brute
        static int FindMaxSubArray(int[] nums)
        {
            int n = nums.Length, maxSum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                for(int j = i; j <n; j++)
                {
                    int sum = 0;
                    for(int k = i; k <= j; k++)
                    {
                        sum += nums[k]; 
                    }
                    maxSum = Math.Max(maxSum, sum);
                }

            }
            return maxSum;
        }


    }
}
