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

        /*
         * This method obtains the necessary infromation from the file to be
         * used later in the application
         */
        public void obtainFileInfo()
        {

        }

        /* 
         * This method is given a file, chosen by the user and outputs the 
         * contents of that file to a textbox in the form.
         */
        public void readFromFile()
        {

        }

        /* 
         * This method writes to a file at a specified location from the user.
         * This method takes a specified file given by the user &
         * writes to the given file the information input. 
         */
        public void writeToFile()
        {
            // all of this code is from a previous application, leaving it in this format to 
            // help in the future when implementing the writeToFile method
            string fileName = DateTime.Now.ToString("MMddyyyy_HHmmss") + "_ShimTotals.txt";
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(documentPath, fileName)))
            {
                // write the header for the file
                outputFile.WriteLine(DateTime.Now.ToString("MM/dd/yyyy | HH:mm:ss"));
                outputFile.WriteLine("TotalShims: " + " | Total Weight: ");
            }
        }
    }
}
