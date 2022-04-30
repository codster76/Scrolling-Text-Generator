using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextGeneratorProgram
{
    public partial class Form1 : Form
    {
        private String backgroundImagePath = "";
        private String saveLocationPath = "";
        private String fontFolderPath = "";
        ScrollingTextGenerator textGenerator = new ScrollingTextGenerator();

        public Form1()
        {
            InitializeComponent();
        }

        public bool validatePath(string path)
        {
            bool status = false;

            if(String.IsNullOrWhiteSpace(path))
            {
                //Console.WriteLine("false");
                return false;
            }

            try
            {
                status = Directory.Exists(path);
            }
            catch (ArgumentException) { }
            catch (NotSupportedException) { }
            catch (PathTooLongException) { }

            //Console.WriteLine(status);
            return status;
        }

        // Events

        private void button_generate_Click(object sender, EventArgs e)
        {
            try
            {
                textGenerator.setBackgroundImage(new Bitmap(backgroundImagePath));
                textGenerator.setSaveLocation(saveLocationPath);
                textGenerator.setText(text_input_text.Text);
                textGenerator.setFontDirectory(fontFolderPath);
                textGenerator.setLeftBoundary((int)numeric_right.Value);
                textGenerator.setRightBoundary((int)numeric_left.Value);
                textGenerator.generateAll();
                label_generate_status.Text = "Generation successful";
            }
            catch (ArgumentException)
            {
                label_generate_status.Text = "Invalid path";
            }
            catch (InvalidCharacterException)
            {
                label_generate_status.Text = "Invalid characters in text";
            }
        }

        private string fixPath(string path)
        {
            return path.Replace(@"\", @"\\");
        }

        private void trackbar_left_ValueChanged(object sender, EventArgs e)
        {
            numeric_right.Value = trackbar_right.Value;
            //numeric_left.Maximum = numeric_right.Value;
            //trackbar_left.Maximum = (int)numeric_right.Value;
        }

        private void numeric_left_ValueChanged(object sender, EventArgs e)
        {
            trackbar_right.Value = (int)numeric_right.Value;
            //numeric_left.Maximum = numeric_right.Value;
            //trackbar_left.Maximum = (int)numeric_right.Value;
        }

        private void trackbar_right_ValueChanged(object sender, EventArgs e)
        {
            numeric_left.Value = trackbar_left.Value;
            numeric_right.Maximum = numeric_left.Value;
            trackbar_right.Maximum = (int)numeric_left.Value;
        }

        private void numeric_right_ValueChanged(object sender, EventArgs e)
        {
            trackbar_left.Value = (int)numeric_left.Value;
            numeric_right.Maximum = numeric_left.Value;
            trackbar_right.Maximum = (int)numeric_left.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog(); // Creates an open file dialog, which is just a window that lets you open files
            fileDialog.Filter = "Image Files|*.jpg;*.png;*.jpeg"; // Filters the type of files you can select, ensuring that you can only select image files
            DialogResult result = fileDialog.ShowDialog(); // showdialog actually opens the file dialog

            if (result == DialogResult.OK) // Looks like DialogResult is an enum for the different result types
            {
                backgroundImagePath = "";
                backgroundImagePath = fileDialog.FileName; // The path of the chosen file
                text_background_image.Text = fileDialog.FileName;
                Bitmap bgImage = new Bitmap(backgroundImagePath);
                picture_preview.Image = bgImage;
                numeric_left.Maximum = bgImage.Width; // set maximum values for boundaries
                trackbar_left.Maximum = bgImage.Width;
            }
        }

        private void button_font_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog(); // Creates an open file dialog, which is just a window that lets you open files
            folderDialog.SelectedPath = Directory.GetCurrentDirectory(); // Starts you in the current directory just so you can avoid extra navigation
            DialogResult result = folderDialog.ShowDialog(); // showdialog actually opens the file dialog

            if (result == DialogResult.OK) // Looks like DialogResult is an enum for the different result types
            {
                fontFolderPath = "";
                fontFolderPath = fixPath(folderDialog.SelectedPath); // The path of the chosen file
                text_font_folder.Text = folderDialog.SelectedPath;
            }
        }

        private void button_save_location_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog(); // Creates an open file dialog, which is just a window that lets you open files
            folderDialog.SelectedPath = Directory.GetCurrentDirectory();
            DialogResult result = folderDialog.ShowDialog(); // showdialog actually opens the file dialog

            if (result == DialogResult.OK) // Looks like DialogResult is an enum for the different result types
            {
                saveLocationPath = "";
                saveLocationPath = fixPath(folderDialog.SelectedPath); // The path of the chosen file
                text_save_location.Text = folderDialog.SelectedPath;
            }
        }

        private void text_background_image_TextChanged(object sender, EventArgs e)
        {
            backgroundImagePath = text_background_image.Text;
        }
    }
}
