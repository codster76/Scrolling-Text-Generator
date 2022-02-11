using System;
using System.Drawing;
using System.Collections;

class ScrollingTextGenerator
{
    private string text;
    private Dictionary<string, string> fontPaths; // Stored as "CharacterName":"path\filename.png"
    private Bitmap fullText;

    public ScrollingTextGenerator(string text)
    {
        this.text = text;
        fontPaths = generateReferenceList();
        createText();
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

    // Generates a bitmap of the text using the images from the font directory
    public void createText()
    {
        // Calculate how large the full text needs to be
        string[] word = new string[text.Count()];
        string capitalisedText = text.ToUpper();
        int imageWidth = 0;
        for(int i = 0;i<text.Count();i++)
        {
            if(Char.IsLetterOrDigit(capitalisedText[i]))
            {
                word[i] = Char.ToString(capitalisedText[i]);
            }
            else if(capitalisedText[i] == 32)
            {
                word[i] = "Space";
            }
            else if(capitalisedText[i] == 33)
            {
                word[i] = "!";
            }
            else if(capitalisedText[i] == 38)
            {
                word[i] = "&";
            }
            else if(capitalisedText[i] == 58)
            {
                word[i] = "Colon";
            }

            try
            {
                //imageWidth += new Bitmap(toAdd).Width;
                imageWidth += new Bitmap(fontPaths[word[i]]).Width;
            }
            catch(System.ArgumentException e)
            {
                Console.WriteLine("Invalid Character");
            }
        }
        // Each letter should be followed by a space except for the last one.
        imageWidth += text.Count() - 1;
        Console.WriteLine(imageWidth);

        fullText = new Bitmap(imageWidth, 7); // Text can only ever take up one line, so the height will always be 7
        int currentStartingPosition = 0;
        for(int x = 0;x<word.Count();x++)
        {
            Bitmap currentLetter = new Bitmap(fontPaths[word[x]]);
            for(int i = 0;i<currentLetter.Width;i++) // starting value of i needs to change for each letter to specify the starting position (replace 0) and ending value needs to change based on letter width (replace fulltext.width)
            {
                for(int j = 0;j<currentLetter.Height;j++)
                {
                    fullText.SetPixel(currentStartingPosition + i, j, currentLetter.GetPixel(i, j));
                }
            }
            // increment starting value by the width of the letter that was just drawn
            currentStartingPosition += currentLetter.Width + 1;

            // Add a space after each letter
            if(x < word.Count() - 1)
            {
                for(int j = 0;j<currentLetter.Height;j++)
                {
                    fullText.SetPixel(currentStartingPosition + 1, j, Color.FromArgb(0, 0, 0, 0));
                }
            }
        }
    }

    public void createTextImage()
    {
        fullText.Save("Words.png");
    }

    public void createFullSequence(int startingX, int startingY, int cutoffPos, Bitmap sourceImage)
    {
        int distanceToMove = Math.Abs(startingX - cutoffPos);
        int totalDistance = distanceToMove + fullText.Width;
        int startingXPos = startingX;
        for(int i = 0;i<totalDistance;i++) // Need to loop totalDistance times to create a separate image for each frame
        {
            Rectangle image = new Rectangle(0,0,sourceImage.Width,sourceImage.Height);
            Bitmap currentImage = sourceImage.Clone(image,0);
            if(startingXPos >= cutoffPos)
            {
                for(int j = 0;j<Math.Min(i,fullText.Width);j++) // The math function ensures that this doesn't try to access out of bounds pixels from the text bitmap
                {
                    for(int k = 0;k<fullText.Height;k++)
                    {
                        currentImage.SetPixel(j+startingXPos,k+startingY,fullText.GetPixel(j,k));
                    }
                }
            }
            else // If the position of the text passes the cutoff position or the edge of the screen, start cutting off the left pixels of the text while continuing to move
            {
                for(int j = cutoffPos - startingXPos;j<Math.Min(i,fullText.Width);j++) // cutoffPos - startingXPos counts up one by one
                {
                    for(int k = 0;k<fullText.Height;k++)
                    {
                        currentImage.SetPixel(j+startingXPos,k+startingY,fullText.GetPixel(j,k));
                    }
                }
            }
            currentImage.Save("Sequence" + i + ".png");
            startingXPos--;
        }
    }
}