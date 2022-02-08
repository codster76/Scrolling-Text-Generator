using System;
using System.Drawing;
using System.Collections;

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

    private Dictionary<string, string> generateReferenceList()
    {
        Dictionary<string, string> referenceList = new Dictionary<string, string>();
        string[] originalList = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Font");
        for(int i = 0;i<originalList.Count();i++)
        {
            string currentString = originalList[i];
            string directoryName = Directory.GetCurrentDirectory() + @"\Font\";
            currentString = currentString.Substring(directoryName.Count(), currentString.Count()-directoryName.Count()-4); // separating the file name from the directory name
            referenceList.Add(currentString, originalList[i]);
        }

        return referenceList;
    }

    public void createText(string text)
    {
        Dictionary<string, string> letterReferenceList = generateReferenceList();
        string[] word = new string[text.Count()];
        string capitalisedText = text.ToUpper();
        int imageWidth = 0;
        for(int i = 0;i<text.Count();i++)
        {
            string toAdd = "";
            if(Char.IsLetterOrDigit(capitalisedText[i]))
            {
                word[i] = capitalisedText[i] + ".png";
                toAdd = letterReferenceList[Char.ToString(capitalisedText[i])];
            }
            else if(capitalisedText[i] == 32)
            {
                word[i] = "Space.png";
                toAdd = letterReferenceList["Space"];
            }
            else if(capitalisedText[i] == 33)
            {
                word[i] = "!.png";
                toAdd = letterReferenceList["!"];
            }
            else if(capitalisedText[i] == 38)
            {
                word[i] = "&.png";
                toAdd = letterReferenceList["&"];
            }
            else if(capitalisedText[i] == 58)
            {
                word[i] = "Colon.png";
                toAdd = letterReferenceList["Colon"];
            }

            try
            {
                imageWidth += new Bitmap(toAdd).Width;
            }
            catch(System.ArgumentException e)
            {
                Console.WriteLine("Invalid Character");
            }
        }
        // Each letter should be followed by a space except for the last one.
        imageWidth += text.Count() - 1;
        Console.WriteLine(imageWidth);
    }
}