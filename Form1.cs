using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorterMidterms
{
    public partial class Form1 : Form
    {
        SortAlg so;

        public Form1()
        {
            InitializeComponent();
            so = new SortAlg(bubbleRichTextBox, binaryRichTextBox);
            this.ControlBox = false;
            this.Text = String.Empty;
            
        }
        string stringValue;
        int[] intValueBin;
        int[] intValueBub;
        private void Button1_Click(object sender, EventArgs e) {
            bool numCheck = true; //used in isdigit
            int parseCheck = 0;

            stringValue = valueTextBox.Text;
            intValueBin = stringValue.Split(' ').Where(i => int.TryParse(i, out parseCheck)).Select(i => parseCheck).ToArray(); //string into int[]; splits every space into an index; to be accessed by binsertion algorithm

            intValueBub = stringValue.Split(' ').Where(i => int.TryParse(i, out parseCheck)).Select(i => parseCheck).ToArray(); // string into int[]; splits every space into an index; to be accessed by bubbly algorithm

            string stringValueDisplay = valueTextBox.Text;
            int[] intValueDisplay = stringValueDisplay.Split(' ').Where(i => int.TryParse(i, out parseCheck)).Select(i => parseCheck).ToArray(); //for displaying purposes; unsorted

            foreach (char c in intValueDisplay) { //checks each element for a digit; for error message
                if (!char.IsDigit(c))
                    numCheck = false;
            }

            if (valueTextBox.Text == String.Empty || numCheck) {
                MessageBox.Show("Invalid value, Please try again");
                return;
            }
            else {
                binaryRichTextBox.Text = "";
                bubbleRichTextBox.Text = "";
                bubbleRichTextBox.Text = "Unsorted \n";
                binaryRichTextBox.Text = "Unsorted \n";

                foreach (var val in intValueDisplay) {
                     binaryRichTextBox.Text += val + " ";
                     bubbleRichTextBox.Text += val + " ";
                 } 
            }
        }

        private void BubbleButton_Click(object sender, EventArgs e) {  
            int[] bubbleInt = intValueBub; 
            so.BubblySort(bubbleInt);
            bubbleRichTextBox.Text += "--------------------------------------------------------------------" + "\nSorted: ";
            foreach (var val in bubbleInt) {
                bubbleRichTextBox.Text += " " + val + " ";
            }
        }

        private void BinaryButton_Click(object sender, EventArgs e) {
            int[] binaryInt = intValueBin;
            so.BInsertionSort(binaryInt);
            binaryRichTextBox.Text += "--------------------------------------------------------------------" + "\nSorted: ";
            foreach (var val in binaryInt)
            {
               binaryRichTextBox.Text += " " + val + " ";
            }
        }

            private void ValueTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e) {
            
            }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void valueTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (valueTextBox.Text.Equals("Enter numbers...") == true) {
                valueTextBox.Text = "";
                valueTextBox.ForeColor = Color.Tomato;
            }
        }

        private void valueTextBox_KeyUp(object sender, KeyEventArgs e) {
            if (valueTextBox.Text.Equals("") == true || valueTextBox.Text.Equals(null) == true) {
                valueTextBox.Text = "Enter number... ";
                valueTextBox.ForeColor = Color.DarkCyan;
            }
        }
    }
    } 
