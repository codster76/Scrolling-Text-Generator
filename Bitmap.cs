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

    public void susify(Bitmap jerma, Bitmap source)
    {
        Bitmap newBM = new Bitmap(source.Width, source.Height);
        int imageToUse = 0;
        
        for(int i = 0;i<newBM.Width;i++)
        {
            for(int j = 0;j<newBM.Height;j++)
            {
                imageToUse = i + j;
                if(imageToUse%2 == 0)
                {
                    newBM.SetPixel(i,j,source.GetPixel(i,j));
                }
                else
                {
                    float jermaWidth = ((float)i/(float)source.Width) * jerma.Width;
                    float jermaHeight = (float)j/(float)source.Height * jerma.Height;
                    newBM.SetPixel(i,j,jerma.GetPixel((int)jermaWidth, (int)jermaHeight));
                }
            }
        }

        newBM.Save("susify.png");
    }
}