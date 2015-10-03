using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay(); // start life grounded
            quackBehavior = new SimpleQuack();
        }
        
        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
