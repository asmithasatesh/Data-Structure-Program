using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    public class Node<T>
    {
        public Node<T> next;
        public T data;
        public int idata;
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
