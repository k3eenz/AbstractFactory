using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class RedFactory : AbstractShapeFactory
    {
        public override IShape CreateCircle()
        {
            return new Circle(Color.Red);
        }

        public override IShape CreateSquare()
        {
            return new Square(Color.Red);
        }

        public override IShape CreateTriangle()
        {
            return new Triangle(Color.Red);
        }
    }

}

