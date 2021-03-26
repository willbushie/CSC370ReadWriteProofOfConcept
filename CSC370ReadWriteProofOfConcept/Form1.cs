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
 * completion of development:   3/26/2021
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
            this.contentsTextBox2.Text = "";
            this.writeSaveAsTextBox.Text = "";
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
            // read in the lines from the contents box
            string writeToFileContents = contentsTextBox2.Text;

            // set a variable to the documents path
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // write the input onto the new file that will be created
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, (writeSaveAsTextBox.Text + ".txt"))))
            {
                outputFile.WriteLine(writeToFileContents);
            }
        }

        // this is the button event for save as
        // this allows the user to chose a file location for the text document to be saved
        // as well as correctly write the contents entered by the user to the file
        private void saveAsButton_Click(object sender, EventArgs e)
        {
            // read in the lines from the contents box
            string writeToFileContents = contentsTextBox2.Text;

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // write the input onto the new file that will be created
                    using (StreamWriter outputFile = new StreamWriter(myStream))
                    {
                        outputFile.WriteLine(writeToFileContents);
                    }
                    myStream.Close();
                }
            }
        }
    }
}
