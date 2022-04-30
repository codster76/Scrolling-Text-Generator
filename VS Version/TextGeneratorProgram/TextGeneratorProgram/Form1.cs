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
        private String imagePath = "";

        public Form1()
        {
            InitializeComponent();
            ScrollingTextGenerator textGenerator = new ScrollingTextGenerator();
        }

        public bool validatePath(string path)
        {
            bool status = false;

            if(String.IsNullOrWhiteSpace(path))
            {
                Console.WriteLine("false");
                return false;
            }

            try
            {
                status = Directory.Exists(path); // doesn't work properly if the user does not format the string properly
            }
            catch (ArgumentException) { }
            catch (NotSupportedException) { }
            catch (PathTooLongException) { }

            Console.WriteLine(status);
            return status;
        }

        // Events
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog(); // Creates an open file dialog, which is just a window that lets you open files
            fileDialog.Filter = "Image Files|*.jpg;*.png;*.jpeg"; // Filters the type of files you can select, ensuring that you can only select image files
            DialogResult result = fileDialog.ShowDialog(); // showdialog actually opens the file dialog

            if (result == DialogResult.OK) // Looks like DialogResult is an enum for the different result types
            {
                imagePath = fileDialog.FileName; // The path of the chosen file
                text_background_image.Text = imagePath;
            }
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            validatePath(@"C:\Users\r2\Videos\Elden Ring");
        }

        private void trackbar_left_ValueChanged(object sender, EventArgs e)
        {
            numeric_left.Value = trackbar_left.Value;
        }

        private void numeric_left_ValueChanged(object sender, EventArgs e)
        {
            trackbar_left.Value = (int)numeric_left.Value;
        }

        private void button_font_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog(); // Creates an open file dialog, which is just a window that lets you open files
            folderDialog.SelectedPath = Directory.GetCurrentDirectory(); // Starts you in the current directory just so you can avoid extra navigation
            DialogResult result = folderDialog.ShowDialog(); // showdialog actually opens the file dialog

            if (result == DialogResult.OK) // Looks like DialogResult is an enum for the different result types
            {
                imagePath = folderDialog.SelectedPath; // The path of the chosen file
                text_font_folder.Text = imagePath;
            }
        }

        private void button_save_location_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog(); // Creates an open file dialog, which is just a window that lets you open files
            folderDialog.SelectedPath = Directory.GetCurrentDirectory();
            DialogResult result = folderDialog.ShowDialog(); // showdialog actually opens the file dialog

            if (result == DialogResult.OK) // Looks like DialogResult is an enum for the different result types
            {
                imagePath = folderDialog.SelectedPath; // The path of the chosen file
                text_save_location.Text = imagePath;
            }
        }
    }
}
