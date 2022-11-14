using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace VisitorDemo
{
    public class Node
    {
        private Persona persona;
        private List<Node> children = new List<Node>();

        public Node(string nombre, int edad)
        {
            persona = new Persona(nombre, edad);
        }

        public string Nombre
        {
            get
            {
                return this.persona.Nombre;
            }
        }

        public int Edad {
            get
            {
                return this.persona.Edad;
            }
        }

        public Persona Persona
        {
            get
            {
                return this.persona;
            }
        } 

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
