namespace BridgeExample
{
    public abstract class Manuscript : IManuscript
    {
        protected readonly IFormatter formatter;

        public Manuscript(IFormatter formatter)
        {
            this.formatter = formatter;
        }

        abstract public void Print();
    }
}