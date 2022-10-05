using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_TranslateAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public bool Test()
        {
            string adress = "http://www.google.com";
            try
            {
                WebRequest request = WebRequest.Create(adress);

                WebResponse response = request.GetResponse();

            }
            catch (Exception)
            {

                return false;

            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if(Test())
            {
                this.Text="There is a connection :)";
            }
            else
            {
                this.Text = "There is no connection :(";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#tr/en/");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#en/tr/");
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = richTextBox1.Text;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = richTextBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if(radioButton1.Checked==true)
            {
                richTextBox2.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
             if(radioButton2.Checked==true)
            {
                richTextBox1.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
