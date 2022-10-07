using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class MaximumAverageSubarrayI
    {
        public static double SlidingWindowQueue(int[] nums, int k)
        {
            double average = double.MinValue;
            var queue = new Queue<int>();
            foreach (int num in nums)
            {
                queue.Enqueue(num);
                if (queue.Count > k)
                    queue.Dequeue();
                    average = Math.Max(average, queue.Sum() / (double)k);
            }
            return average;
        }

        public static double SlidingWindowNativePath(int[] nums, int k)
        {
            double average = double.MinValue;
            for (int i = 0; i <= nums.Length - k; i++)
            {
                double tempAvarage = 0;
                for (int j = i; j < i + k; j++)
                    tempAvarage += nums[j];
                tempAvarage /= k;
                if (average < tempAvarage)
                    average = tempAvarage;
            }
            return average;
        }

        public static double SlidingWindowAccumulation(int[] nums, int k)
        {
            double average = double.MinValue;
            double currentAverage = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == k)
                {
                    average = Math.Max(currentAverage / (double)k, average);
                }
                if (count > k)
                {
                    currentAverage -= nums[i - k];
                    average = Math.Max(currentAverage / (double)k, average);
                }
                currentAverage += nums[i];
                count++; 
            }
            return average;
        }

        public static double SlidingWindowVeryFast(int[] nums, int k)
        {
            double currentMax = nums.Take(k).Sum();
            double maxNums = currentMax;
            for (int i = k; i < nums.Length; i++)
            {
                currentMax -= nums[i - k];
                currentMax += nums[i];
                if (maxNums < currentMax)
                    maxNums = currentMax;
            }
            return maxNums / (double)k;
        }

        public static double SlidingWindowLinq(int[] nums, int k)
        {
            double average = double.MinValue;
            for (int i = 0; i <= nums.Length - k; i++)
            {
                var segment = nums.Skip(i).Take(k);
                double tempAvarage = segment.Sum() / (double)k;
                Console.WriteLine(segment.Sum() + " " + string.Join(' ', segment));
                if (average < tempAvarage)
                    average = tempAvarage;
            }
            return average;
        }

        public static double SlidingWindowArraySegment(int[] nums, int k)
        {
            double average = double.MinValue;
            for (int i = 0; i <= nums.Length - k; i++)
            {
                var segment = new ArraySegment<int>(nums, i, k);
                double tempAvarage = segment.Sum() / (double)k;
                if (average < tempAvarage)
                    average = tempAvarage;
            }
            return average;
        }
        

    }
}
