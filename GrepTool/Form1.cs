using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GrepTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void KeywordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Course.txt");
            String fileText = sr.ReadToEnd();
            sr.Close();
            fileContent.Text = fileText;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            fileContent.Text = "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Course.txt");

            String updateText = fileContent.Text;

            sw.Write(updateText);
            sw.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string keywordStr = keywordTxt.Text;
            resultTxt.Text = "";
            StreamReader sr = new StreamReader("Course.txt");
            int lineNumber = 0;
            int counter = 0;
            int position = 0;
            string line = "";

            while ((line = sr.ReadLine()) != null)
            {
                lineNumber++;

                position = line.IndexOf(keywordStr);
                if (position > -1)
                {
                    resultTxt.Text += ("line: " + lineNumber + ". Position: " + position);
                    resultTxt.AppendText(Environment.NewLine);
                    counter++;
                }
            }
            sr.Close();
        }
    }
}
