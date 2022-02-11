using System;
using System.Drawing;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap jerma = new Bitmap(Directory.GetCurrentDirectory() + @"\JermaSus.jpg");
            Bitmap sus = new Bitmap(Directory.GetCurrentDirectory() + @"\source.png");
            Bitmap textBar = new Bitmap(Directory.GetCurrentDirectory() + @"\Text Bar.png");
            bitMapTest test = new bitMapTest();
            ScrollingTextGenerator textGenerator = new ScrollingTextGenerator("Prev");
            //test.susify(jerma, sus);
            textGenerator.createTextImage();
            textGenerator.createFullSequence(227,4,218,textBar);
        }
    }
}