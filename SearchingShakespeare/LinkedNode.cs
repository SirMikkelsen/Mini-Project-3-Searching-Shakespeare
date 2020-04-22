using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingShakespeare
{
    public class LinkedNode : Node
    {
        private Node _node;
        private Key _key;
        public override void add(Key key, int value)
        {
            throw new NotImplementedException();
        }

        public override int Find(Key key)
        {
            throw new NotImplementedException();
        }

        public override Node locate(Key key)
        {
            throw new NotImplementedException();
        }
    }
}
