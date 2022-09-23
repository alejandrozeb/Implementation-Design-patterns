namespace VisitorPattern
{
    public class Circle : IShape
    {
        public void accept(IVisitor v)
        {
            v.VisitCircle(this);
        }

        public void draw()
        {
            Console.WriteLine("Circle drawing");
        }

        public void move(int x, int y)
        {
            Console.WriteLine("Circle moving");
        }
    }
}
