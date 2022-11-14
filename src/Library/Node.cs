using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;

        public Persona person; 

        public List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number, Persona person)
        {
            this.number=number;
            this.person= person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
    }
}
