using System;

namespace DotNet_FirstArrayLTESecondArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 4, 2, 4 };
            int[] maxes = { 3, 5 };
        
            Counts(nums, maxes);

            Console.ReadLine();
        }
        static void Counts(int[] nums, int[] maxes)
        {
            int MAX_CAPACITY = 100000;
            int[] arr = new int[100000];
            
            for (int i = 0; i < nums.Length; i++)
                arr[nums[i]]++;
            
            //catat masing dalam array
            //1 ada 1
            //2 ada 1
            //4 ada 2
  
            for (int i = 1; i < MAX_CAPACITY; i++)
            {
                arr[i] = arr[i] + arr[i - 1];
            }

            //arr[1] = 1 => 1 + arr[0] = 1
            //arr[2] = 1 => 1 + arr[1] = 2
            //arr[3] = 1 => 1 + arr[2] = 2
            //arr[4] = 2 => 2 + arr[2] = 4

            for (int i = 0; i < maxes.Length; i++)
            {
                Console.Write(arr[maxes[i]] + " ");
            }
        }
    }
}
