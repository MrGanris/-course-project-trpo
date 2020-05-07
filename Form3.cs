using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irregularVerbsCS
{
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void form3_Load(object sender, EventArgs e)
        {

        }
        private void проверкаГлаголаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            form1 newForm = new form1();
            newForm.Show();
        }
        private void списокВсехToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 newForm = new Form2();
            newForm.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
