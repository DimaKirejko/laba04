using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba04
{
    internal class BSTNode
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }

        public BSTNode(int key, string value)
        {
            Key = key;
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
