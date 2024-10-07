using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class BlueFactory : AbstractShapeFactory
    {
        public override IShape CreateCircle()
        {
            return new Circle(Color.Blue);
        }

        public override IShape CreateSquare()
        {
            return new Square(Color.Blue);
        }

        public override IShape CreateTriangle()
        {
            return new Triangle(Color.Blue);
        }
    }

}
