using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class MergingLists
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
              .Split(" ")
              .Select(int.Parse)
              .ToList();

            List<int> list2 = Console.ReadLine()
              .Split(" ")
              .Select(int.Parse)
              .ToList();

            int limit = 0;
            if (list1.Count > list2.Count)
            {
                limit = list2.Count;
            }
            else
            {
                limit = list1.Count;
            }

            List<int> resultList = new List<int>(list1.Count + list2.Count);
            for (int i = 0; i < limit; i++)
            {
                resultList.Add(list1[i]);
                resultList.Add(list2[i]);
            }

            if (list1.Count > list2.Count)
            {
                resultList.AddRange(GetRemainingValues(list1, list2));
            }
            else
            {
                resultList.AddRange(GetRemainingValues(list2, list1));
            }
            Console.WriteLine(String.Join(" ", resultList));
        }

        static List<int> GetRemainingValues(List<int> longerList, List<int> shorterList)
        {
            List<int> result = new List<int>(longerList.Count - shorterList.Count);
            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                result.Add(longerList[i]);
            }

            return result;
        }
    }
}
