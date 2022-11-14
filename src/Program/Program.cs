using System;

namespace VisitorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nodo1 = new Node("Federico", 19);
            Node nodo11 = new Node("Gaston", 24);
            Node nodo12 = new Node("Laura", 20);
            Node nodo121 = new Node("Mateo", 26);
            Node nodo1211 = new Node("Beethoven", 21);

            nodo121.AddChildren(nodo1211);
            nodo12.AddChildren(nodo121);
            nodo1.AddChildren(nodo12);
            nodo1.AddChildren(nodo11);

            SumaEdadesContent SumaEdades = new SumaEdadesContent(nodo1);
            Console.WriteLine(SumaEdades.GetEdad());

            HijoMayorContent HijoMayor = new HijoMayorContent(nodo1);
            Console.WriteLine(HijoMayor.GetPersona().Nombre);

            MayorNombreContent MayorNombre = new MayorNombreContent(nodo1);
            Console.WriteLine(MayorNombre.GetPersona().Nombre);
        }
    }
}
