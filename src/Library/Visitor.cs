using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public abstract class Visitor<T>
    {
        public string visitor
        {
            get
            {
                return this.visitor;
            }
        }

        public abstract void Visitar(Node node);

    }
}