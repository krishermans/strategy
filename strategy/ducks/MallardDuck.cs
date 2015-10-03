using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new SimpleQuack();
            flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
