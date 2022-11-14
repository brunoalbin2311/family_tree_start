namespace VisitorDemo
{
    public class SumaEdadesContent
    {
        private Node node;

        public SumaEdadesContent(Node node)
        {
            this.node = node;
        }

        public int GetEdad()
        {
            SumaEdadesVisitor visitor = new SumaEdadesVisitor();
            node.Accept(visitor);
            return visitor.SumaEdades;
        }
    }
}