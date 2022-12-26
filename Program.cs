using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PrototypeFigure
{
    class Figures
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IFigure figure = new Square(15);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            figure = new Circle(15);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            figure = new Triangle(3, 4, 5);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            Console.Read();
        }
    }
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
    class Square : IFigure
    {
        int lenght;
        public Square(int l)
        {
            lenght = l;
        }
        public IFigure Clone()
        {
            return new Square(this.lenght);
        }
        public void GetInfo()
        {
            Console.WriteLine("Квадрат зі стороною {15}", lenght);
        }
    }
    class Triangle : IFigure
    {
        int side1;
        int side2;
        int side3;
        public Triangle(int s1, int s2, int s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }
        public IFigure Clone()
        {
            return new Triangle(this.side1, this.side2, this.side3);
        }
        public void GetInfo()
        {
            Console.WriteLine("Трикутник зі сторонами {0}, {1} і {2}", side1, side2, side3);
        }
    }
    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }
        public IFigure Clone()
        {
            return new Circle(this.radius);
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радіусом {0}", radius);
        }
    }
}