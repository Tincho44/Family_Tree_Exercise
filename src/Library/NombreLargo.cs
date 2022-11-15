using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class NombreLargo : Visitor
    {
        private string NamePersonResult { get; set; }

        public NombreLargo()
        {
            this.NamePersonResult = "";
        }

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
            string name = Regex.Replace(person.Nombre, @"\s", "");
            string nameResult = Regex.Replace(this.NamePersonResult, @"\s", "");
            
            if (nameResult.Length < name.Length)
            {
                this.ChangeResult(person.Nombre);
            }
            
        }

        public void ChangeResult(string name)
        {
            this.NamePersonResult = name;
        }
        public override string GetResult()
        {
            return this.NamePersonResult;
        }
    }
}



