namespace VisitorDemo
{
    public abstract class Visitor
    {
        public abstract void Visit(Persona persona);

        public abstract void Visit(Node node);
    }
}