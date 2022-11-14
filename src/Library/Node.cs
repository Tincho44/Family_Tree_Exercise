using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
        private int number;

        public T Value { get; set; }

        public List<Node<T>> children = new List<Node<T>>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number)
        {
            this.number=number;
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        
    }
}
