namespace VisitorDemo
{
    public class HijoMayorContent
    {
        private Node node;

        public HijoMayorContent(Node node)
        {
            this.node = node;
        }

        public Persona GetPersona()
        {
            HijoMayorVisitor visitor = new HijoMayorVisitor();
            foreach (Node hijo in node.Children) 
            {
                hijo.Accept(visitor);
            }
            return visitor.Persona;
        }
    }
}