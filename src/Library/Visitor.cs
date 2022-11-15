using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public abstract class Visitor
    {
        public abstract void VisitNode(Node node);

        public abstract void VisitPerson(Persona person);

        public abstract string GetResult();

    }
}

