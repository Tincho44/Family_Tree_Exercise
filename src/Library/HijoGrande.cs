using System;

namespace Library
{
    public class HijoGrande : IVisitor
    {
        private string NombrePersona { get; set; }
        private int EdadPersona { get; set; }

        public HijoGrande()
        {
            this.NombrePersona = "";
            this.EdadPersona = 0;
        }
        public void VisitNode(Node node)
        {   

            foreach (Node n in node.Children)
            {
                n.person.Accept(this);
                n.Accept(this);
            }
        }

        public void VisitPerson(Persona person)
        {
            int age = person.Edad;
            if (this.EdadPersona < age)
            {
                this.ChangeResult(person.nombre,age);
            }
            
        }

        public void ChangeResult(string name, int age)
        {

            this.EdadPersona = age;
            this.NombrePersona = name;
        }
        public string GetResult()
        {
            string datos = $"Nombre: {this.NombrePersona}, Edad: {this.EdadPersona}";
            return datos;
        }
    }
}

