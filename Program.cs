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
            bitMapTest test = new bitMapTest();
            //test.susify(jerma, sus);
            test.createText("");
        }
    }
}