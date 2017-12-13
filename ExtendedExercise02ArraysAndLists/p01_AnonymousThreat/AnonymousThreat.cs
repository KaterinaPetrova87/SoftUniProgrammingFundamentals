using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p01_AnonymousThreat
{
    public class AnonymousThreat
    {
        public static void Main()
        {
            List<string> data = Console.ReadLine()
                .Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>x.Trim())
                .ToList();
            string[] command = Console.ReadLine().Split();

            while(command[0] != "3:1")
            {
                if(command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    data = MergeMethod(data, startIndex, endIndex);
                }
                else if(command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);

                    data = DivideMethod(data, index, partitions);
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", data));
        }

        public static List<string> DivideMethod(List<string> data, int index, int partitions)
        {
            string element = data[index];
            int partitionLength = element.Length / partitions;

            List<string> dividedPartitions = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                if(i == partitions - 1)
                {
                    dividedPartitions.Add(element.Substring(i * partitionLength));
                }
                else
                {
                    dividedPartitions.Add(element.Substring(i * partitionLength, partitionLength));
                }
            }

            data.RemoveAt(index);
            data.InsertRange(index, dividedPartitions);

            return data;
        }

        public static List<string> MergeMethod(List<string> data, int startIndex, int endIndex)
        {
            List<string> newList = new List<string>();

            startIndex = ChangeIndex(startIndex, data.Count);
            endIndex = ChangeIndex(endIndex, data.Count);

            for (int i = 0; i < startIndex; i++)
            {
                newList.Add(data[i]);
            }

            StringBuilder result = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                result.Append(data[i]);
            }

            newList.Add(result.ToString());

            for (int i = endIndex+1; i < data.Count; i++)
            {
                newList.Add(data[i]);
            }
            return newList;
        }

        public static int ChangeIndex(int index, int length)
        {
            if (index < 0)
            {
                index = 0;
            }
            if (index > length - 1)
            {
                index = length - 1;
            }
            return index;
        }
    }
}
