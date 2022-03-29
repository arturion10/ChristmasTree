using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class CristmosTree
    {
        internal string GetHalfCristmosTreeRecording(int num)
        {
            var sbTree = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                sbTree.Append('*', i + 1);
                sbTree.Append('\n');
            }
            return sbTree.ToString();
        }

        internal string GetCristmosTreeRecording(int num)
        {
            var decrementNumber = num;
            var sbTree = new StringBuilder();
            sbTree.Append(' ', decrementNumber--).Append("*\n");

            for (var i = 0; i < num - 1; i++)
            {
                sbTree.Append(' ', decrementNumber--).Append('*');
                sbTree.Append('*', (i + 1) * 2);
                sbTree = sbTree.Append('\n');
            }
            return sbTree.ToString();
        }
    }
}
