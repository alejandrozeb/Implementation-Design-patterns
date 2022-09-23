namespace VisitorPattern
{
    public interface IVisitor
    {
        void VisitDot(Dot d);

        void VisitCircle(Circle c);

        void VisitRectangle(Rectangle r);

        void VisitCompoundShape(CompoundShape cs);

    }
}
