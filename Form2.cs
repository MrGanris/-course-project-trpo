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

namespace irregularVerbsCS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StreamReader str = new StreamReader("IrregV.txt", Encoding.Default);
            while (!str.EndOfStream)
            {
                string st = str.ReadLine();
                textBox2.Text += st + Environment.NewLine;
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void прверитьГлаголToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            form1 newForm = new form1();
            newForm.Show();

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            form3 newForm = new form3();
            newForm.Show();

        }
    }
}
