using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingShakespeare
{
    public class LinkedNode : Node
    {
        
        private Node _more;
        private LinkedNode _next;
        
        private Key _key;
        public override void Add(Key key, int value)
        {
            throw new NotImplementedException();
        }

        public override int Find(Key key)
        {
            throw new NotImplementedException();
        }

        public override Node Locate(Key key)
        {
            throw new NotImplementedException();
        }
    }
}
