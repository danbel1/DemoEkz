using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void clientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show(this);
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detailEquipmentToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show(this);
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show(this);
        }

        private void orderPartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show(this);
        }

        private void orderPartsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show(this);
        }

        private void detailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show(this);
        }

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show(this);
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show(this);
        }
    }
}
