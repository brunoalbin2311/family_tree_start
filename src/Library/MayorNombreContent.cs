namespace VisitorDemo
{
    public class MayorNombreContent
    {
        private Node node;

        public MayorNombreContent(Node node)
        {
            this.node = node;
        }

        public Persona GetPersona()
        {
            MayorNombreVisitor visitor = new MayorNombreVisitor();
            node.Accept(visitor);
            return visitor.Persona;
        }
    }
}