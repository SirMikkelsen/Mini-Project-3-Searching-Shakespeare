using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingShakespeare
{
   public class Node
    {
        public Node()
        {
            Label = "";
            SubNodes = new List<Node>();
        }

        public Node(string l)
        {
            Label = l;
            SubNodes = new List<Node>();
        }
        public string Label;
        public List<Node> SubNodes;
    }
}
}
    