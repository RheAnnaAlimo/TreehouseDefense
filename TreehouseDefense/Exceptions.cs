using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class TreehouseDefenseExceptions : Exception
    {
        public TreehouseDefenseExceptions()
        { }
        public TreehouseDefenseExceptions(string message) : base(message)
        {
        }
    }
    class OutofBoundsException : TreehouseDefenseExceptions
    {
        public OutofBoundsException()
        {
        }
        public OutofBoundsException(string message) : base (message)
        {

        }
    }
}
