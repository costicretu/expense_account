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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button_IntroducereDate_Click(object sender, EventArgs e)
        {
            Debit d = new Debit();
            Credit c = new Credit();
            
            
            if (textBoxSID.Text.Length > 0)
            {
                d.soldInitialDebitor = textBoxSID.Text;
            }
            else
            {
                errorProvider1.SetError(textBoxSID, "Adauga sold initial debitor");
            }
            string sID = "Sold inițial debitor";
            TreeNode node_sID = new TreeNode(sID);
            node_sID.Nodes.Add(textBoxSID.Text);
            treeViewDebit.Nodes.Add(node_sID);

            string intrari = "Intrări";
            TreeNode node_Intrari = new TreeNode(intrari);
            if (textBoxRD1.Text.Length > 0)
            {
                node_Intrari.Nodes.Add(textBoxRD1.Text);
            }
            else
            {
                errorProvider1.SetError(textBoxRD1, "Adauga rulaj debitor");
            }
            if (textBoxRD2.Text.Length > 0)
            {
                node_Intrari.Nodes.Add(textBoxRD2.Text);
            }
            else
            {
                errorProvider1.SetError(textBoxRD2, "Adauga rulaj debitor");
            }
            if (textBoxRD3.Text.Length > 0)
            {
                node_Intrari.Nodes.Add(textBoxRD3.Text);
            }
            else
            {
                errorProvider1.SetError(textBoxRD3, "Adauga rulaj debitor");
            }
            treeViewDebit.Nodes.Add(node_Intrari);
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
            int totalSD = int.Parse(d.soldInitialDebitor) + int.Parse(d.rulajDebitor);
            node_TSD.Nodes.Add(totalSD.ToString());
            treeViewDebit.Nodes.Add(node_TSD);

            string iesiri = "Ieșiri";
            TreeNode node_Iesiri = new TreeNode(iesiri);
            if (textBoxRC1.Text.Length > 0)
            {
                node_Iesiri.Nodes.Add(textBoxRC1.Text);
            }
            else
            {
                errorProvider1.SetError(textBoxRC1, "Adauga rulaj creditor");
            }
            if (textBoxRC2.Text.Length > 0)
            {
                node_Iesiri.Nodes.Add(textBoxRC2.Text);
            }
            else
            {
                errorProvider1.SetError(textBoxRC2, "Adauga rulaj creditor");
            }
            if (textBoxRC3.Text.Length > 0)
            {
                node_Iesiri.Nodes.Add(textBoxRC3.Text);
            }
            else
            {
                errorProvider1.SetError(textBoxRC3, "Adauga rulaj creditor");
            }
            treeViewCredit.Nodes.Add(node_Iesiri);
            int textBoxRC1_copy = int.Parse(textBoxRC1.Text);
            int textBoxRC2_copy = int.Parse(textBoxRC2.Text);
            int textBoxRC3_copy = int.Parse(textBoxRC3.Text);
            int sumRC = textBoxRC1_copy + textBoxRC2_copy + textBoxRC3_copy;
            c.rulajCreditor = sumRC.ToString();
            string RC = "Rulaj creditor";
            TreeNode node_RC = new TreeNode(RC);
            node_RC.Nodes.Add(sumRC.ToString());
            treeViewCredit.Nodes.Add(node_RC);

            string TSC = "Total sume creditoare";
            TreeNode node_TSC = new TreeNode(TSC);
            node_TSC.Nodes.Add(sumRC.ToString());
            treeViewCredit.Nodes.Add(node_TSC);

            int sFD = totalSD - sumRC;
            d.soldFinalDebitor = sFD.ToString();
            string SFD = "Sold final debitor";
            if (sFD < 0)
            {
                TreeNode node_SFD = new TreeNode(SFD);
                node_SFD.Nodes.Add(d.soldFinalDebitor.ToString());
                treeViewDebit.Nodes.Add(node_SFD);
            }
            else
            {
                TreeNode node_SFC = new TreeNode(SFD);
                node_SFC.Nodes.Add(d.soldFinalDebitor.ToString());
                treeViewCredit.Nodes.Add(node_SFC);
            }
            
            treeViewDebit.ExpandAll();
            treeViewCredit.ExpandAll();

            chart1.Series["Valori cont debitor"].Points.AddXY("Sold inițial debitor", d.soldInitialDebitor);
            chart1.Series["Valori cont debitor"].Points.AddXY("Rulaj debitor", d.rulajDebitor);
            chart1.Series["Valori cont debitor"].Points.AddXY("Sold final debitor", d.soldFinalDebitor);
            chart1.Titles.Add("Grafic cont debitor");
        }
        private void salvareDateÎnFișierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\Facultate\Programarea aplicațiilor Windows\Projects\Proiect\Output\ContDebitor.txt";
            if (!File.Exists(fileName))
            {
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    writer.WriteLine("Sold inițial debitor:" + textBoxSID.Text);
                    writer.WriteLine("Rulaj debitor 1:" + textBoxRD1.Text);
                    writer.WriteLine("Rulaj debitor 2:" + textBoxRD2.Text);
                    writer.WriteLine("Rulaj debitor 3:" + textBoxRD3.Text);
                    writer.WriteLine("Rulaj creditor 1:" + textBoxRC1.Text);
                    writer.WriteLine("Rulaj creditor 2:" + textBoxRC2.Text);
                    writer.WriteLine("Rulaj creditor 3:" + textBoxRC3.Text);
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

        private void textBoxRD1_DragDrop(object sender, DragEventArgs e)
        {
            if ((e.KeyState & 8) == 8 && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move) 
                e.Effect = DragDropEffects.Move;
        }
        private void textBoxRD1_DragEnter(object sender, DragEventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (text != null)
                text.Text += e.Data.GetData(DataFormats.Text);
            if (e.Effect == DragDropEffects.Move)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
