using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;


namespace Library
{
    public class AgesSum : IVisitor

    {
        public int Result { get; set; }

        public void VisitNode(Node node)
        {   

            node.person.Accept(this);

            foreach (Node n in node.Children)
            {
                n.Accept(this);
            }
        }

        public void VisitPerson(Persona person)
        {
            this.ChangeResult(person.Edad);
        }

        public string GetResult()
        {
            return this.Result.ToString();
        }
        public void ChangeResult(int age)
        {
            this.Result = Result + age;
        }

    }
}