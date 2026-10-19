using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class Container<T>
    {
        private T? con;
        public void Add(T Value)
        {
            con=Value;
        }
        public T? Get()
        {
            return con;
        }
    }
}
