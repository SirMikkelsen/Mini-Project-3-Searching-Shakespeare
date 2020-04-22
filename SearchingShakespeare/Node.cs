using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingShakespeare
{
   public abstract class Node
    {
       public abstract void Add(Key key, int value);
       public abstract int Find(Key key);
       public abstract Node Locate(Key key);
    }
}
    