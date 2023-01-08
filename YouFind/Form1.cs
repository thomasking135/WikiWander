using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouFind
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string add = "/wiki/";

            webBrowser1.Navigate("https://www.wikipedia.org" + add + textBox1.Text); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            webBrowser1.Document.Write("Ready for a new search?");
            webBrowser1.Navigate("https://placekitten.com/200/300");
        }

    }
}


