using System;

namespace DotNet_FirstArrayLTESecondArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 4, 2, 4 };
            int[] maxes = { 3, 5 };
        
            int[] result = Counts(nums, maxes);
            
            Console.WriteLine(string.Join(' ', result));

            Console.ReadLine();
        }
        static int[] Counts(int[] nums, int[] maxes)
        {
            int[] result = new int[maxes.Length];

            Array.Sort(nums);

            for (int i = 0; i < maxes.Length; i++)
            {
                int idx = Search( nums, maxes[i]);
                //karena index bukan length jadi +1
                result[i] = idx + 1;
            }

            return result;
        }

        static int Search(int[] nums, int max)
        {
            int l =0;
            int h = nums.Length - 1;

            while (l <= h)
            {
                int mid = (l + h) / 2;
                
                if (nums[mid] <= max)
                    l = mid + 1;
                
                else
                    h = mid - 1;
            }
            
            return h;
        }
    }
}
