/* 
 * CSC370 - Assignment #18 - Proof of concept
 * this application is a proof of concept that will read and write to a specified file from the user
 * 
 * This application is from Team 1. The team members are:
 *      Hannah Neymeyer - Team Lead
 *      Caden Flowers - Front End Developer
 *      Nicholas Johnson - Designer/Architect
 *      William Bushie - Programmer
 *      
 * start of development:        3/24/2021
 * completion of development:   NOT YET COMPLETED
 * 
 */

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

namespace CSC370ReadWriteProofOfConcept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // this button event clear the text file & contents text boxes
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.contentsTextBox.Text = "";
            this.textFileTextBox.Text = "";
        }


        // this is the button event of showButton
        private void showButton_Click(object sender, EventArgs e)
        {
            // obtain the file name from the user
            string filename = this.textFileTextBox.Text;

            // read the entire fiel as one string
            string text = System.IO.File.ReadAllText(path: @filename); 

            // display the file contents to the output window
            this.contentsTextBox.Text = text;
        }

        // this is the button event of opening a file location
        // it will read the file and enter its contents into the contents text box,
        // as well as input the file path in the text file text box
        private void openFileButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // get the path of the spcified file 
                    filePath = openFileDialog.FileName;

                    // read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            // place the file path into the text file text box
            this.textFileTextBox.Text = filePath;

            // output the contents of the stream to the contents text box
            this.contentsTextBox.Text = fileContent;
        }


        // this is the button event for writing to a file
        // as of now, everything is hardcoded - the name of the file & the contents
        // this method successfully creates a new file with the hardcoded information in the documents folder
        private void writeButton_Click(object sender, EventArgs e)
        {
            // create a string array with the lines of text
            string[] lines = {"first line", "second line", "third line"};

            // set a variable to the documents path
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // write the string array to a new file named "WriteLines.txt"
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
            }

            // all of this code is from a previous application, leaving it in this format to 
            // help in the future when implementing the writeToFile method
            /*string fileName = DateTime.Now.ToString("MMddyyyy_HHmmss") + "_ShimTotals.txt";
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(documentPath, fileName)))
            {
                // write the header for the file
                outputFile.WriteLine(DateTime.Now.ToString("MM/dd/yyyy | HH:mm:ss"));
                outputFile.WriteLine("TotalShims: " + " | Total Weight: ");
            }
            */
        }

        // this is the button event for saving as
        // 
        private void saveAsButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // code to write the stream goes here
                    myStream.Close();
                    MessageBox.Show("this is a test");
                }
            }
        }
    }
}
