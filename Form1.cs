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
using System.Drawing.Printing;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_IntroducereCont_Click(object sender, EventArgs e)
        {
            Cont c = new Cont();
            if (textBoxCont.Text.Length > 0)
            {
                c.nrCont = textBoxCont.Text;
            }
            else
            {
                errorProvider1.SetError(textBoxCont, "Adauga un cont valid");
            }
            if (comboBoxTipCont.Text.Length > 0)
            {
                c.tipCont = comboBoxTipCont.Text;
            }
            else
            {
                errorProvider1.SetError(comboBoxTipCont, "Adauga un cont valid");
            }

            if (comboBoxTipCont.Text == "Activ")
            {
                Form2 form = new Form2();
                form.ShowDialog();
            }
            else
            {
                Form3 form = new Form3();
                form.ShowDialog();
            }
        }
        private void salveazăDateleÎnFișierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\Facultate\Programarea aplicațiilor Windows\Projects\Proiect\Output\Cont.txt";
            if (!System.IO.File.Exists(fileName))
            {
                using (StreamWriter writer = System.IO.File.CreateText(fileName))
                {
                    writer.WriteLine("Cont:" + textBoxCont.Text);
                    writer.WriteLine("Tip cont:" + comboBoxTipCont.Text);
                }
            }
            MessageBox.Show("✔️");
        }
        private void imprimareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
