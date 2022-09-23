namespace VisitorPattern
{
    public class CompoundShape : IShape
    {
        public void accept(IVisitor v)
        {
            v.VisitCompoundShape(this);
        }

        public void draw()
        {
            Console.WriteLine("Compound drawing");
        }

        public void move(int x, int y)
        {
            Console.WriteLine("Compound moving");
        }
    }
}
