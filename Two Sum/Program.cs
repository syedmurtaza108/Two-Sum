using System;

namespace Two_Sum
{
    class Program
    {
        static int potentialAnswer = -1;
        /*
         Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        You can return the answer in any order.*/
        static void Main(string[] args)
        {
            int[] a = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            a = TwoSum(new int[] { 3, 3 }, 6);
            Console.WriteLine(a[0] + ", " + a[1]);
        }

        static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target) return new int[] { i, j };
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
