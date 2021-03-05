using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LiskovSubstitutionPrinciple
{
    class LiskovSubstitution
    {
        public void Run()
        {
            Console.WriteLine("Liskov substitution principle");
            Console.WriteLine("#1");
            //Bad way
            Console.WriteLine("Bad way");
            var badSizeShaper = new BadWay.SizeShaper();
            var badRectangle = new BadWay.Rectangle();
            badSizeShaper.ChangeRectangleShapeSize(badRectangle, 20, 10);
            var badRectangleArea = badRectangle.GetArea();
            Console.WriteLine(badRectangleArea);
            var badSquare = new BadWay.Square();
            badSizeShaper.ChangeRectangleShapeSize(badSquare, 20, 10);
            var badSquareArea = badSquare.GetArea();
            Console.WriteLine(badSquareArea);

            //Good way
            Console.WriteLine("Good way");
            var goodSizeShaper = new GoodWay.SizeShaper();
            var goodRectangle = new GoodWay.Rectangle();
            goodSizeShaper.ChangeRectangleShapeSize(goodRectangle, 20, 10);
            var goodRectangleArea = goodRectangle.GetArea();
            Console.WriteLine(goodRectangleArea);
            var goodSquare = new GoodWay.Square();
            goodSizeShaper.ChangeSquareShapeSize(goodSquare, 20);
            var goodSquareArea = goodSquare.GetArea();
            Console.WriteLine(goodSquareArea);


            Console.WriteLine("#2");
            //Bad way
            Console.WriteLine("Bad way");
            new BadWay2.Footer().Render();
            new BadWay2.Header().Render();
            new BadWay2.HOC().Render();

            //Good way
            Console.WriteLine("Good way");
            new GoodWay2.Footer().Render();
            new GoodWay2.Header().Render();


            Console.WriteLine();
        }
    }
}
