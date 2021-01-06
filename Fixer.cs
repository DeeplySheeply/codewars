using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is a simple coding problem that displays knowledge of the List interface in C#. This is the first problem I solved using lists and so my technique is somewhat basic.

namespace Fixer
{
    public class Fixer
    {
        public static List<int> PipeFix(List<int> numbers)
        {
            List<int> returnNumbers = new List<int>();

            for (int i = numbers[0]; i < numbers[numbers.Count-1]; i++)
            {
                returnNumbers.Add(i);
            }
            return returnNumbers;
        }
    }
}
