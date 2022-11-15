using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona Pepito = new Persona("Pepe", 44);
            Persona Pepita = new Persona("Pepita",42);
            Persona Pepito2 = new Persona("Pepe2", 34);
            Persona Pepita2 = new Persona("Pepita2",32);
            Persona Pepito3 = new Persona("Pepe3", 24);
            Persona Pepita3 = new Persona("Pepita3",22);
            Persona Pepito4 = new Persona("Pepe4", 14);
            Persona Pepita4 = new Persona("Pepita4",12);


            Node n1 = new Node(1, Pepito);
            Node n2 = new Node(2,Pepita);
            Node n3 = new Node(3, Pepito);
            Node n4 = new Node(4,Pepita);            
            Node n5 = new Node(5, Pepito);
            Node n6 = new Node(6,Pepita);
            Node n7 = new Node(7, Pepito);
            Node n8  = new Node(8,Pepita);   

            //Ejemplo demostrativo, claramente las edades no estan muy correlacionadas

            n1.AddChildren(n2);

            Visitor SumaEdades = new AgesSum();
            Visitor HijoViejo = new HijoGrande();
            Visitor NombreLargo = new NombreLargo();

            n1.Accept(SumaEdades);
            n1.Accept(HijoViejo);
            n1.Accept(NombreLargo);

        }
    }
}
