using System;
using System.Collections.Generic;
using System.Text;

namespace MorseCodeParser
{
    public class Node
    {
        public string Value { get; set; }

        public Node DotNode { get; set; }

        public Node DashNode { get; set; }

        public Node(string value)
        {
            Value = value;
        }
    }
}
