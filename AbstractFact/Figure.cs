using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    public class Circle : IShape
    {
        private Color _color;

        public Circle(Color color)
        {
            _color = color;
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(_color), 10, 10, 50, 50);
        }
    }
    public class Square : IShape
    {
        private Color _color;

        public Square(Color color)
        {
            _color = color;
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(_color), 10, 10, 50, 50);
        }
    }
    public class Triangle : IShape
    {
        private Color _color;

        public Triangle(Color color)
        {
            _color = color;
        }

        public void Draw(PaintEventArgs e)
        {
            Point[] points = {new Point(10, 10), new Point(60, 10), new Point(35, 60)};
            e.Graphics.FillPolygon(new SolidBrush(_color), points);
        }
    }

}
