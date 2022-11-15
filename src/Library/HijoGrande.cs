using System;

namespace Library
{
    public class HijoGrande : Visitor
    {
        private string NamePersonResult { get; set; }
        private int AgePersonResult { get; set; }

        public HijoGrande()
        {
            this.NamePersonResult = "";
            this.AgePersonResult = 0;
        }
        public override void VisitNode(Node node)
        {   

            foreach (Node n in node.Children)
            {
                n.person.Accept(this);
                n.Accept(this);
            }
        }

        public override void VisitPerson(Persona person)
        {
            int age = person.Edad;
            if (this.AgePersonResult < age)
            {
                this.ChangeResult(person.nombre,age);
            }
            
        }

        public void ChangeResult(string name, int age)
        {

            this.AgePersonResult = age;
            this.NamePersonResult = name;
        }
        public override string GetResult()
        {
            string text = $"Nombre: {this.NamePersonResult}, Edad: {this.AgePersonResult}";
            return text;
        }
    }
}