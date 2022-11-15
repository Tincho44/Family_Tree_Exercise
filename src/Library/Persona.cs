using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{

    public class Persona
    {

        public string nombre;
        public int edad;

        public Persona (string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public int Edad
        {

            get
            {
                return this.edad;
            }

            set
            {
                this.edad = value;
            }
        }
        public void Accept(Visitor visitor)
        {
            visitor.VisitPerson(this);
        }
    }
}
