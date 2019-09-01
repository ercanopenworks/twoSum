using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoSum
{
    class Program
    {

        public static int[] twoSum(int[] nums, int target)
        {
            //Dictionary<int, int> map = new Dictionary<int, int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    map.Add(nums[i], i);
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int complement = target - nums[i];
            //    if (map.ContainsKey(complement) && map[complement] != i)
            //    {
            //        return new int[] { i, map[complement] };
            //    }
            //}
            //return null;

            Dictionary<int, int> map = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }

            return null;
        }
        static void Main(string[] args)
        {

            int[] nums = { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };
            int target = 542;
            //int[] nums = { 3,3 };
            //int target = 6;

            int[] res = twoSum(nums, target);

            Console.WriteLine(res[0].ToString() + "," + res[1].ToString());

            Console.ReadKey();
        }
    }
}
