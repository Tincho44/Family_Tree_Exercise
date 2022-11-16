using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class NombreLargo : IVisitor
    {
        private string NombrePersona { get; set; }

        public NombreLargo()
        {
            this.NombrePersona = "";
        }

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
            string name = Regex.Replace(person.Nombre, @"\s", "");
            string nameResult = Regex.Replace(this.NombrePersona, @"\s", "");

            // Regex es una serie de simbolos, se usa system para regular expressions para habilitarla
            // Sinceremente esta parte la saque de un colega que tiene mas experiencia
            
            if (nameResult.Length < name.Length)
            {
                this.ChangeResult(person.Nombre);
            }
            
        }

        public void ChangeResult(string name)
        {
            this.NombrePersona = name;
        }
        public string GetResult()
        {
            return this.NombrePersona;
        }
    }
}



