using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public interface IVisitor
    {
        public void VisitNode(Node node);
        public  void VisitPerson(Persona person);
        public string GetResult();

    }
}

