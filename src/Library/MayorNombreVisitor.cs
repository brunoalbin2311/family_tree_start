namespace VisitorDemo
{
    public class MayorNombreVisitor : Visitor
    {
        private Persona persona;

        public Persona Persona
        {
            get
            {
                return persona;
            }
        }

        public override void Visit(Persona persona)
        {
            if (this.persona is null || this.persona.Nombre.Length < persona.Nombre.Length)
            {
                this.persona = persona;
            }
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