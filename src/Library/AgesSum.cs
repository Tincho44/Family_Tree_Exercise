using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;


namespace Library
{
    public class AgesSum : Visitor

    {
        public int Result { get; set; }

        public override void VisitNode(Node node)
        {   

            node.person.Accept(this);

            foreach (Node n in node.Children)
            {
                n.Accept(this);
            }
        }

        public override void VisitPerson(Persona person)
        {
            this.ChangeResult(person.Edad);
        }

        public void ChangeResult(int age)
        {
            this.Result = Result + age;
        }
        public override string GetResult()
        {
            return this.Result.ToString();
        }

    }
}