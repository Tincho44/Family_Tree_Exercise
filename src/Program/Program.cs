using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona Pepito = new Persona("Pepe", 44);
            Persona Pepitasa = new Persona("Pepita",42);
            Persona Pepito2 = new Persona("Pepe2", 34);
            Persona Pepita2 = new Persona("Pepita2",32);
            Persona Pepito3 = new Persona("Pepe3", 24);
            Persona Pepita3 = new Persona("Pepita3",22);
            Persona Pepito4 = new Persona("Pepe4", 14);
            Persona Pepita4 = new Persona("Pepita490",12);


            Node n1 = new Node(1, Pepito);
            Node n2 = new Node(2,Pepitasa);
            Node n3 = new Node(3, Pepito2);
            Node n4 = new Node(4,Pepita2);            
            Node n5 = new Node(5, Pepito3);
            Node n6 = new Node(6,Pepita3);
            Node n7 = new Node(7, Pepito4);
            Node n8  = new Node(8,Pepita4);   

            //Ejemplo demostrativo, claramente las edades no estan muy correlacionadas

            n1.AddChildren(n2);

            n2.AddChildren(n4);

            n2.AddChildren(n5);

            n3.AddChildren(n6);

            n4.AddChildren(n7);

            n7.AddChildren(n8);

            IVisitor SumaEdades = new AgesSum();
            IVisitor HijoViejo = new HijoGrande();
            IVisitor NombreLargo = new NombreLargo();

            n1.Accept(SumaEdades);
            n1.Accept(HijoViejo);
            n1.Accept(NombreLargo);

            Console.WriteLine("Suma hijo mayor -> " + HijoViejo.GetResult());
            // Te devuelve el nombre y edad del hijo mayor, en este caso Pepito
            Console.WriteLine("Sumar todas las edades -> " + SumaEdades.GetResult());
            // suma las edades de los nodos
            Console.WriteLine("Hijo con nombre mas largo -> " + NombreLargo.GetResult());
            //Deberia de devolverme pepita490

        }
    }
}
