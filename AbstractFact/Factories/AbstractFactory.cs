using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public interface IShape
    {
        void Draw(PaintEventArgs e);
    }
    public abstract class AbstractShapeFactory
    {
        public abstract IShape CreateCircle();
        public abstract IShape CreateSquare();
        public abstract IShape CreateTriangle();
    }
}
