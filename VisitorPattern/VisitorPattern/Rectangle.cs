namespace VisitorPattern
{
    public class Rectangle : IShape
    {
        public void accept(IVisitor v)
        {
            v.VisitRectangle(this);
        }

        public void draw()
        {
            Console.WriteLine("Rectangle Drawing");
        }

        public void move(int x, int y)
        {
            Console.WriteLine("Rectangle moving");
        }
    }
}
