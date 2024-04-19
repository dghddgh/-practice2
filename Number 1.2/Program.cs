using System;
using System.Collections.Generic;


namespace Number_1._2
{
    class Program
    {
        static void Main()
        {
            int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
            int target = 8;
            var result = CombinationSum2(candidates, target);
            foreach (var res in result)
            {
                Console.WriteLine(string.Join(", ", res));
            }
        }
        public static List<List<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            List<List<int>> result = new List<List<int>>();
            CombinationSum2(candidates, target, 0, new List<int>(), result);
            return result;
        }
        private static void CombinationSum2(int[] candidates, int target, int start, List<int> current, List<List<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(current));
                return;
            }
            for (int i = start; i < candidates.Length && candidates[i] <= target; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1])
                {
                    continue; 
                }
                current.Add(candidates[i]);
                CombinationSum2(candidates, target - candidates[i], i + 1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }

}