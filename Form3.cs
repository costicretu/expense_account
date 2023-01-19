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

namespace Proiect
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button_IntroducereDate_Click(object sender, EventArgs e)
        {
            Credit c = new Credit();
            Debit d = new Debit();
            if (textBoxSIC.Text.Length > 0)
            {
                c.soldInitialCreditor = textBoxSIC.Text;
            }
            else
            {
                errorProvider1.SetError(textBoxSIC, "Adauga sold initial creditor");
            }
            string sIC = "Sold inițial creditor";
            TreeNode node_sIC = new TreeNode(sIC);
            node_sIC.Nodes.Add(textBoxSIC.Text);
            treeViewCredit.Nodes.Add(node_sIC);

            string intrari = "Creșteri";
            TreeNode node_Intrari = new TreeNode(intrari);
            node_Intrari.Nodes.Add(textBoxRC1.Text);
            node_Intrari.Nodes.Add(textBoxRC2.Text);
            node_Intrari.Nodes.Add(textBoxRC3.Text);
            treeViewCredit.Nodes.Add(node_Intrari);

            int textBoxRC1_copy = int.Parse(textBoxRC1.Text);
            int textBoxRC2_copy = int.Parse(textBoxRC2.Text);
            int textBoxRC3_copy = int.Parse(textBoxRC3.Text);
            int sumRC = textBoxRC1_copy + textBoxRC2_copy + textBoxRC3_copy;
            if (sumRC != 0)
            {
                c.rulajCreditor = sumRC.ToString();
            }
            else
            {
                errorProvider1.SetError(textBoxRC1, "Adauga rulaj creditor");
            }
            string RC = "Rulaj creditor";
            TreeNode node_RC = new TreeNode(RC);
            node_RC.Nodes.Add(sumRC.ToString());
            treeViewCredit.Nodes.Add(node_RC);

            string TSC = "Total sume creditoare";
            TreeNode node_TSC = new TreeNode(TSC);
            int totalSC = int.Parse(c.soldInitialCreditor) + int.Parse(c.rulajCreditor);
            node_TSC.Nodes.Add(totalSC.ToString());
            treeViewCredit.Nodes.Add(node_TSC);

            string iesiri = "Diminuări";
            TreeNode node_Iesiri = new TreeNode(iesiri);
            if (textBoxRD1.Text.Length > 0)
            {
                node_Iesiri.Nodes.Add(textBoxRD1.Text);
            }
            else
            {
                errorProvider1.SetError(textBoxRD1, "Adauga rulaj debitor");
            }
            if (textBoxRD2.Text.Length > 0)
            {
                node_Iesiri.Nodes.Add(textBoxRD2.Text);
            }
            else
            {
                errorProvider1.SetError(textBoxRD2, "Adauga rulaj debitor");
            }
            if (textBoxRD3.Text.Length > 0)
            {
                node_Iesiri.Nodes.Add(textBoxRD3.Text);
            }
            else
            {
                errorProvider1.SetError(textBoxRD3, "Adauga rulaj debitor");
            }
            treeViewDebit.Nodes.Add(node_Iesiri);

            int textBoxRD1_copy = int.Parse(textBoxRD1.Text);
            int textBoxRD2_copy = int.Parse(textBoxRD2.Text);
            int textBoxRD3_copy = int.Parse(textBoxRD3.Text);
            int sumRD = textBoxRD1_copy + textBoxRD2_copy + textBoxRD3_copy;
            d.rulajDebitor = sumRD.ToString();
            string RD = "Rulaj debitor";
            TreeNode node_RD = new TreeNode(RD);
            node_RD.Nodes.Add(sumRD.ToString());
            treeViewDebit.Nodes.Add(node_RD);

            string TSD = "Total sume debitoare";
            TreeNode node_TSD = new TreeNode(TSD);
            node_TSD.Nodes.Add(sumRD.ToString());
            treeViewDebit.Nodes.Add(node_TSD);

            int sFC = totalSC - sumRD;
            c.soldFinalCreditor = sFC.ToString();
            string SFC = "Sold final creditor";
            if (sFC < 0)
            {
                TreeNode node_SFC = new TreeNode(SFC);
                node_SFC.Nodes.Add(c.soldFinalCreditor.ToString());
                treeViewCredit.Nodes.Add(node_SFC);
            }
            else
            {
                TreeNode node_SFD = new TreeNode(SFC);
                node_SFD.Nodes.Add(c.soldFinalCreditor.ToString());
                treeViewDebit.Nodes.Add(node_SFD);
            }

            treeViewCredit.ExpandAll();
            treeViewDebit.ExpandAll();

            chart1.Series["Valori cont creditor"].Points.AddXY("Sold inițial creditor", c.soldInitialCreditor);
            chart1.Series["Valori cont creditor"].Points.AddXY("Rulaj creditor", c.rulajCreditor);
            chart1.Series["Valori cont creditor"].Points.AddXY("Sold final creditor", c.soldFinalCreditor);
            chart1.Titles.Add("Grafic cont creditor");
        }
        private void salvareDateÎnFișierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\Facultate\Programarea aplicațiilor Windows\Projects\Proiect\Output\ContCreditor.txt";
            if (!File.Exists(fileName))
            {
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    writer.WriteLine("Sold inițial creditor:" + textBoxSIC.Text);
                    writer.WriteLine("Rulaj creditor 1:" + textBoxRC1.Text);
                    writer.WriteLine("Rulaj creditor 2:" + textBoxRC2.Text);
                    writer.WriteLine("Rulaj creditor 3:" + textBoxRC3.Text);
                    writer.WriteLine("Rulaj debitor 1:" + textBoxRD1.Text);
                    writer.WriteLine("Rulaj debitor 2:" + textBoxRD2.Text);
                    writer.WriteLine("Rulaj debitor 3:" + textBoxRD3.Text);
                }
            }
            MessageBox.Show("✔️");
        }
        private void imprimareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void textBoxRC1_DragDrop(object sender, DragEventArgs e)
        {
            if ((e.KeyState & 8) == 8 && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }

        private void textBoxRC1_DragEnter(object sender, DragEventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (text != null)
                text.Text += e.Data.GetData(DataFormats.Text);
            if (e.Effect == DragDropEffects.Move)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
