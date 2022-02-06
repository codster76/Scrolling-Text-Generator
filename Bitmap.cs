using System;
using System.Drawing;
using System.IO;

class bitMapTest
{
    Bitmap bm = new Bitmap(Directory.GetCurrentDirectory() + @"\image.png");
    public void printColours()
    {
        for(int i = 0;i<bm.Width;i++)
        {
            for(int j = 0;j<bm.Height;j++)
            {
                Console.WriteLine(bm.GetPixel(i,j));
            }
        }
    }

    public void changeToColour(Color c)
    {
        Bitmap newBM = new Bitmap(bm.Width, bm.Height);
        
        for(int i = 0;i<bm.Width;i++)
        {
            for(int j = 0;j<bm.Height;j++)
            {
                newBM.SetPixel(i,j,c);
            }
        }

        newBM.Save("new.png");
    }
}