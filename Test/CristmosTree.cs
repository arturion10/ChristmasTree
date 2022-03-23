using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class CristmosTree
    {
        internal string HalfCristmosTreeRecording(int num)
        {
            var tree = "";
            for (int i = 0; i < num; i++)
            {
                tree += string.Concat(Enumerable.Repeat("*", i + 1)) + "\n";
            }
            return tree;
        }

        internal string CristmosTreeRecording(int num)
        {
            var decrementNumber = num;
            var tree = string.Concat(Enumerable.Repeat(" ", decrementNumber--)) + "*\n";

            for (var i = 0; i < num - 1; i++)
            {
                tree += string.Concat(Enumerable.Repeat(" ", decrementNumber--));
                tree += string.Concat(Enumerable.Repeat("**", i + 1)) + "*\n";
            }
            return tree;
        }
    }
}
