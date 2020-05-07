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
using System.Globalization;

namespace irregularVerbsCS
{

    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            StreamReader str = new StreamReader("IrregV.txt", Encoding.Default);
            while (!str.EndOfStream)
            {
                string st = str.ReadLine();
                if (textBox1.Text != "")
                {
                    if (st.StartsWith(textBox1.Text + "\t"))
                    {

                        MessageBox.Show(st, "Формы неправильного глагола");
                        flag = true;
                        break;
                    }
                }
            }
            if (!flag)
                MessageBox.Show("Этот глагол правильный");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
        private void справкаОПравильныхИНеПравильныхГлаголахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3 newForm = new form3();
            newForm.Show();
        }
    }
}
