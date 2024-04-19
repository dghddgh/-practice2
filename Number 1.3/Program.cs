using System;

namespace Number_1._3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4 };
            Console.WriteLine(Uniqueness(nums1));

            int[] nums2 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(Uniqueness(nums2));
        }

        static bool Uniqueness(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}