namespace VisitorDemo
{
    public class SumaEdadesVisitor : Visitor
    {
        private int sumaEdades = 0;

        public int SumaEdades
        {
            get
            {
                return sumaEdades;
            }
        }

        public override void Visit(Persona persona)
        {
            sumaEdades += persona.Edad;
        }

        public override void Visit(Node node)
        {
            node.Persona.Accept(this);
            foreach (Node hijo in node.Children)
            {
                hijo.Accept(this);
            }
        }
    }
}