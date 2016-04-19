namespace Abstraction
{
    using Abstraction.Contracts;

    internal abstract class Figure : IFigure
    {
        internal abstract double CalcPerimeter();

        internal abstract double CalcSurface();
    }
}