using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    static class ExtensionString
    {
        public static int SquareOfLength(this string str)
        {
            return str.Length * str.Length;
        }
    }
}
