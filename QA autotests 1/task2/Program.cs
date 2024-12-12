using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
    Migratory Birds
    Найти в списке самый часто встречающийся ID птицы и вывести его. Если таких несколько, вывести минимальный ID

     Input: 1 2 3 4 5 4 3 2 1 3 4
     Output: 3
     */

    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> birdCounts = new Dictionary<int, int>();
        foreach (int bird in arr)
        {
            if (birdCounts.ContainsKey(bird))
            {
                birdCounts[bird]++;
            }
            else
            {
                birdCounts[bird] = 1;
            }
        }

        int maxCount = 0;
        int minId = int.MaxValue;

        foreach (var bird in birdCounts)
        {
            if (bird.Value > maxCount || (bird.Value == maxCount && bird.Key < minId))
            {
                maxCount = bird.Value;
                minId = bird.Key;
            }
        }

        return minId;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);
        Console.WriteLine(result);

    }
}