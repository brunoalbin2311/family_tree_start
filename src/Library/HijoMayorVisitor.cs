namespace VisitorDemo
{
    public class HijoMayorVisitor : Visitor
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
            if (this.persona is null || this.persona.Edad < persona.Edad)
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