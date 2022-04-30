using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.IO;

class ScrollingTextGenerator
{
    private string text;
    private Dictionary<string, string> fontReferenceList; // Stored as "CharacterName":"path\filename.png"
    private Bitmap fullText;
    private int leftBoundary;
    private int rightBoundary;
    private int textHeight = 9; // How high on the background image the text is drawn
    private Bitmap backgroundImage;
    private string saveLocation;

    public ScrollingTextGenerator()
    {
        text = "";
        fontReferenceList = new Dictionary<string, string>();
        fullText = new Bitmap(1, 1);
        leftBoundary = 0;
        rightBoundary = 0;
        textHeight = 9;
        backgroundImage = new Bitmap(1, 1);
        saveLocation = "";
    }

    private void generateReferenceList()
    {
        Dictionary<string, string> referenceList = new Dictionary<string, string>();
        string[] originalList = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Font");
        string directoryName = Directory.GetCurrentDirectory() + @"\Font\";
        for (int i = 0; i < originalList.Length; i++)
        {
            string currentString = originalList[i];
            currentString = currentString.Substring(directoryName.Length, currentString.Length - directoryName.Length - 4); // separating the file name from the directory name
            referenceList.Add(currentString, originalList[i]);
        }
        fontReferenceList = referenceList;
    }

    // Generates a bitmap of the text using the images from the font directory. The text on each frame of the sequence is copied from this.
    public void createText()
    {
        // Calculate how large the full text needs to be
        string[] word = new string[text.Length];
        string capitalisedText = text.ToUpper();
        int imageWidth = 0;

        // Basically, what's happening in this loop is that it's going through every letter of the input text, finding the corresponding letter from the font folder and adding its length onto a total
        for (int i = 0; i < text.Length; i++)
        {
            // Taking each letter and converting it to match the font file names (so a becomes A to match A.png or unicode 33 becomes ! to match !.png).
            if (Char.IsLetterOrDigit(capitalisedText[i]))
            {
                word[i] = Char.ToString(capitalisedText[i]);
            }
            else if (capitalisedText[i] == 32) // Checking for specific unicode characters
            {
                word[i] = "Space";
            }
            else if (capitalisedText[i] == 33)
            {
                word[i] = "!";
            }
            else if (capitalisedText[i] == 38)
            {
                word[i] = "&";
            }
            else if (capitalisedText[i] == 58)
            {
                word[i] = "Colon";
            }

            try
            {
                //imageWidth += new Bitmap(toAdd).Width;
                imageWidth += new Bitmap(fontReferenceList[word[i]]).Width;
            }
            catch (System.ArgumentException e)
            {
                Console.WriteLine("Invalid Character");
            }
        }
        // Each letter should be followed by a space except for the last one.
        imageWidth += text.Length - 1;
        Console.WriteLine(imageWidth);

        fullText = new Bitmap(imageWidth, 7); // Text can only ever take up one line, so the height will always be 7. Could replace with a standardised font height later.
        int currentStartingPosition = 0;

        // Draws each letter one by one. Drawing column by column, left to right.
        for (int x = 0; x < word.Length; x++)
        {
            Bitmap currentLetter = new Bitmap(fontReferenceList[word[x]]);
            for (int i = 0; i < currentLetter.Width; i++) // starting value of i needs to change for each letter to specify the starting position (replace 0) and ending value needs to change based on letter width (replace fulltext.width)
            {
                for (int j = 0; j < currentLetter.Height; j++)
                {
                    fullText.SetPixel(currentStartingPosition + i, j, currentLetter.GetPixel(i, j));
                }
            }
            // increment starting value by the width of the letter that was just drawn
            currentStartingPosition += currentLetter.Width + 1;

            // Add a space after each letter
            if (x < word.Length - 1)
            {
                for (int j = 0; j < currentLetter.Height; j++)
                {
                    fullText.SetPixel(currentStartingPosition + 1, j, Color.FromArgb(0, 0, 0, 0));
                }
            }
        }
    }

    // Generates every image in sequence, starting from the text completely off the edge of the bar to the text leaving the bar
    public void createFullSequence()
    {
        int distanceToMove = Math.Abs(rightBoundary - leftBoundary); // The text will be drawn from startingX and move left towards the cutoffPos, where it'll disappear as it passes
        int totalDistance = distanceToMove + fullText.Width; // The text starts outside of the drawn area, so the length of the text needs to be taken into account
        int startingXPos = rightBoundary;
        for (int i = 0; i < totalDistance; i++) // Need to loop totalDistance times to create a separate image for each frame
        {
            Rectangle image = new Rectangle(0, 0, backgroundImage.Width, backgroundImage.Height);
            Bitmap currentImage = backgroundImage.Clone(image, 0);
            if (startingXPos >= leftBoundary)
            {
                for (int j = 0; j < Math.Min(i, fullText.Width); j++) // The math function ensures that this doesn't try to access out of bounds pixels from the text bitmap
                {
                    for (int k = 0; k < fullText.Height; k++)
                    {
                        currentImage.SetPixel(j + startingXPos, k + textHeight, fullText.GetPixel(j, k));
                    }
                }
            }
            else // If the position of the text passes the cutoff position or the edge of the screen, start cutting off the left pixels of the text while continuing to move
            {
                for (int j = leftBoundary - startingXPos; j < Math.Min(i, fullText.Width); j++) // cutoffPos - startingXPos counts up one by one
                {
                    for (int k = 0; k < fullText.Height; k++)
                    {
                        currentImage.SetPixel(j + startingXPos, k + textHeight, fullText.GetPixel(j, k));
                    }
                }
            }
            currentImage.Save("Sequence" + i + ".png");
            startingXPos--; // Negative because the text is moving right to left
        }
    }

    // Setters
    public void setText(string text)
    {
        this.text = text;
    }

    public void setLeftBoundary(int value)
    {
        leftBoundary = value;
    }

    public void setRightBoundary(int value)
    {
        rightBoundary = value;
    }

    public void setBackgroundImage(Bitmap backgroundImage)
    {
        this.backgroundImage = backgroundImage;
    }

    public void setSaveLocation(string location)
    {
        saveLocation = location;
    }
}