namespace VisitorPattern
{
    public class Dot : IShape
    {
        public void accept(IVisitor v)
        {
            v.VisitDot(this);
        }

        public void draw()
        {
            Console.WriteLine("dot drawing");
        }

        public void move(int x, int y)
        {
            Console.WriteLine("dot moving");
        }
    }
}
