using System;
using System.Collections.Generic;
using System.Linq;

namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            //Create ConcreteComponent and two Decorators
            AbstractChristmasTree xmasTreeWithBalls = new ChristmasTree("XmasTreeWithBalls");
            xmasTreeWithBalls = new XmasBallsDecorator(xmasTreeWithBalls);
            ((XmasBallsDecorator)xmasTreeWithBalls).AddBalls("red");
            ((XmasBallsDecorator)xmasTreeWithBalls).AddBalls("golden");


            AbstractChristmasTree xmasTreeWithLights = new ChristmasTree("XmasTreeWithLights");
            xmasTreeWithLights = new XmasLightsDecorator(xmasTreeWithLights);


            AbstractChristmasTree xmasTreeWithBallsAndLights = new ChristmasTree("XmasTreeWithBallsAndLights");
            xmasTreeWithBallsAndLights = new XmasBallsDecorator(xmasTreeWithBallsAndLights);
            ((XmasBallsDecorator)xmasTreeWithBallsAndLights).AddBalls("green");
            ((XmasBallsDecorator)xmasTreeWithBallsAndLights).AddBalls("yellow");
            ((XmasBallsDecorator)xmasTreeWithBallsAndLights).AddBalls("blue");
            xmasTreeWithBallsAndLights = new XmasLightsDecorator((AbstractChristmasTree)xmasTreeWithBallsAndLights);

            // Get Info
            xmasTreeWithBalls.GetInfo();
            Console.WriteLine();
            xmasTreeWithLights.GetInfo();
            Console.WriteLine();
            xmasTreeWithBallsAndLights.GetInfo();

            // Wait for user
            Console.Read();
        }
    }

    abstract class AbstractChristmasTree
    {
        public abstract void GetInfo();
    }

    class ChristmasTree : AbstractChristmasTree
    {
        private string _name;
        public ChristmasTree(string name)
        {
            _name = name;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"This is {_name}");
        }
    }

    abstract class Decorator : AbstractChristmasTree
    {
        protected AbstractChristmasTree tree;

        public Decorator(AbstractChristmasTree tree)
        {
            this.tree = tree;
        }

        public override void GetInfo()
        {
            if (tree != null)
            {
                tree.GetInfo();
            }
        }
    }

    class XmasBallsDecorator : Decorator
    {
        private List<string> xmasBalls = new List<string>();

        public XmasBallsDecorator(AbstractChristmasTree tree) : base(tree) { }

        public void AddBalls(string color)
        {
            xmasBalls.Add($"{color} ball");
        }

        public override void GetInfo()
        {
            base.GetInfo();
            if (xmasBalls.Any())
            {
                Console.WriteLine("It is decorated with such elements: ");

                Console.WriteLine(string.Join(", ", xmasBalls));
            }
            else
            {
                Console.WriteLine("It is not decorated");
            }
        }
    }

    class XmasLightsDecorator : Decorator
    {
        public XmasLightsDecorator(AbstractChristmasTree tree) : base(tree) { }

        public bool CanShine()
        {
            return true;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            string canShine = CanShine() ? "can" : "cannot";
            Console.WriteLine($"This Christmas tree {canShine} shine");
        }
    }
}
