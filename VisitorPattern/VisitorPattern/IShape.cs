namespace VisitorPattern
{
    public interface IShape
    {
        void move(int x, int y);
        void draw();
        void accept(IVisitor v );
    }
}
