﻿
namespace Proiect
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.treeViewCredit = new System.Windows.Forms.TreeView();
            this.treeViewDebit = new System.Windows.Forms.TreeView();
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelDebit = new System.Windows.Forms.Label();
            this.button_IntroducereDate = new System.Windows.Forms.Button();
            this.textBoxSIC = new System.Windows.Forms.TextBox();
            this.labelSID = new System.Windows.Forms.Label();
            this.labelCresteri = new System.Windows.Forms.Label();
            this.labelDiminuari = new System.Windows.Forms.Label();
            this.textBoxRC1 = new System.Windows.Forms.TextBox();
            this.textBoxRC2 = new System.Windows.Forms.TextBox();
            this.textBoxRC3 = new System.Windows.Forms.TextBox();
            this.textBoxRD3 = new System.Windows.Forms.TextBox();
            this.textBoxRD2 = new System.Windows.Forms.TextBox();
            this.textBoxRD1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fișierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareDateÎnFișierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(20, 380);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Valori cont creditor";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(711, 369);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // treeViewCredit
            // 
            this.treeViewCredit.Location = new System.Drawing.Point(429, 65);
            this.treeViewCredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeViewCredit.Name = "treeViewCredit";
            this.treeViewCredit.Size = new System.Drawing.Size(199, 260);
            this.treeViewCredit.TabIndex = 29;
            // 
            // treeViewDebit
            // 
            this.treeViewDebit.Location = new System.Drawing.Point(183, 65);
            this.treeViewDebit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeViewDebit.Name = "treeViewDebit";
            this.treeViewDebit.Size = new System.Drawing.Size(199, 260);
            this.treeViewDebit.TabIndex = 28;
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Location = new System.Drawing.Point(425, 46);
            this.labelCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(45, 17);
            this.labelCredit.TabIndex = 27;
            this.labelCredit.Text = "Credit";
            // 
            // labelDebit
            // 
            this.labelDebit.AutoSize = true;
            this.labelDebit.Location = new System.Drawing.Point(179, 46);
            this.labelDebit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDebit.Name = "labelDebit";
            this.labelDebit.Size = new System.Drawing.Size(41, 17);
            this.labelDebit.TabIndex = 26;
            this.labelDebit.Text = "Debit";
            // 
            // button_IntroducereDate
            // 
            this.button_IntroducereDate.Location = new System.Drawing.Point(337, 334);
            this.button_IntroducereDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_IntroducereDate.Name = "button_IntroducereDate";
            this.button_IntroducereDate.Size = new System.Drawing.Size(133, 28);
            this.button_IntroducereDate.TabIndex = 25;
            this.button_IntroducereDate.Text = "&Introduceți datele";
            this.button_IntroducereDate.UseVisualStyleBackColor = true;
            this.button_IntroducereDate.Click += new System.EventHandler(this.button_IntroducereDate_Click);
            // 
            // textBoxSIC
            // 
            this.textBoxSIC.AllowDrop = true;
            this.textBoxSIC.Location = new System.Drawing.Point(16, 65);
            this.textBoxSIC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSIC.Name = "textBoxSIC";
            this.textBoxSIC.Size = new System.Drawing.Size(132, 22);
            this.textBoxSIC.TabIndex = 18;
            this.textBoxSIC.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragDrop);
            this.textBoxSIC.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragEnter);
            // 
            // labelSID
            // 
            this.labelSID.AutoSize = true;
            this.labelSID.Location = new System.Drawing.Point(16, 43);
            this.labelSID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSID.Name = "labelSID";
            this.labelSID.Size = new System.Drawing.Size(124, 17);
            this.labelSID.TabIndex = 17;
            this.labelSID.Text = "Sold inițial creditor";
            // 
            // labelCresteri
            // 
            this.labelCresteri.AutoSize = true;
            this.labelCresteri.Location = new System.Drawing.Point(16, 94);
            this.labelCresteri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCresteri.Name = "labelCresteri";
            this.labelCresteri.Size = new System.Drawing.Size(57, 17);
            this.labelCresteri.TabIndex = 32;
            this.labelCresteri.Text = "Creșteri";
            // 
            // labelDiminuari
            // 
            this.labelDiminuari.AutoSize = true;
            this.labelDiminuari.Location = new System.Drawing.Point(16, 218);
            this.labelDiminuari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiminuari.Name = "labelDiminuari";
            this.labelDiminuari.Size = new System.Drawing.Size(67, 17);
            this.labelDiminuari.TabIndex = 33;
            this.labelDiminuari.Text = "Diminuări";
            // 
            // textBoxRC1
            // 
            this.textBoxRC1.AllowDrop = true;
            this.textBoxRC1.Location = new System.Drawing.Point(16, 113);
            this.textBoxRC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRC1.Name = "textBoxRC1";
            this.textBoxRC1.Size = new System.Drawing.Size(132, 22);
            this.textBoxRC1.TabIndex = 36;
            this.textBoxRC1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragDrop);
            this.textBoxRC1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragEnter);
            // 
            // textBoxRC2
            // 
            this.textBoxRC2.AllowDrop = true;
            this.textBoxRC2.Location = new System.Drawing.Point(16, 145);
            this.textBoxRC2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRC2.Name = "textBoxRC2";
            this.textBoxRC2.Size = new System.Drawing.Size(132, 22);
            this.textBoxRC2.TabIndex = 35;
            this.textBoxRC2.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragDrop);
            this.textBoxRC2.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragEnter);
            // 
            // textBoxRC3
            // 
            this.textBoxRC3.AllowDrop = true;
            this.textBoxRC3.Location = new System.Drawing.Point(16, 177);
            this.textBoxRC3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRC3.Name = "textBoxRC3";
            this.textBoxRC3.Size = new System.Drawing.Size(132, 22);
            this.textBoxRC3.TabIndex = 34;
            this.textBoxRC3.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragDrop);
            this.textBoxRC3.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragEnter);
            // 
            // textBoxRD3
            // 
            this.textBoxRD3.AllowDrop = true;
            this.textBoxRD3.Location = new System.Drawing.Point(16, 302);
            this.textBoxRD3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRD3.Name = "textBoxRD3";
            this.textBoxRD3.Size = new System.Drawing.Size(132, 22);
            this.textBoxRD3.TabIndex = 37;
            this.textBoxRD3.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragDrop);
            this.textBoxRD3.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragEnter);
            // 
            // textBoxRD2
            // 
            this.textBoxRD2.AllowDrop = true;
            this.textBoxRD2.Location = new System.Drawing.Point(16, 270);
            this.textBoxRD2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRD2.Name = "textBoxRD2";
            this.textBoxRD2.Size = new System.Drawing.Size(132, 22);
            this.textBoxRD2.TabIndex = 38;
            this.textBoxRD2.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragDrop);
            this.textBoxRD2.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragEnter);
            // 
            // textBoxRD1
            // 
            this.textBoxRD1.AllowDrop = true;
            this.textBoxRD1.Location = new System.Drawing.Point(16, 238);
            this.textBoxRD1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRD1.Name = "textBoxRD1";
            this.textBoxRD1.Size = new System.Drawing.Size(132, 22);
            this.textBoxRD1.TabIndex = 39;
            this.textBoxRD1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragDrop);
            this.textBoxRD1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxRC1_DragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fișierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(747, 28);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fișierToolStripMenuItem
            // 
            this.fișierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareDateÎnFișierToolStripMenuItem,
            this.imprimareToolStripMenuItem});
            this.fișierToolStripMenuItem.Name = "fișierToolStripMenuItem";
            this.fișierToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fișierToolStripMenuItem.Text = "Fișier";
            // 
            // salvareDateÎnFișierToolStripMenuItem
            // 
            this.salvareDateÎnFișierToolStripMenuItem.Name = "salvareDateÎnFișierToolStripMenuItem";
            this.salvareDateÎnFișierToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.salvareDateÎnFișierToolStripMenuItem.Text = "Salvare date în fișier";
            this.salvareDateÎnFișierToolStripMenuItem.Click += new System.EventHandler(this.salvareDateÎnFișierToolStripMenuItem_Click);
            // 
            // imprimareToolStripMenuItem
            // 
            this.imprimareToolStripMenuItem.Name = "imprimareToolStripMenuItem";
            this.imprimareToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.imprimareToolStripMenuItem.Text = "Imprimare";
            this.imprimareToolStripMenuItem.Click += new System.EventHandler(this.imprimareToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "10 ",
            "20 ",
            "30 ",
            "40 ",
            "50 ",
            "60 ",
            "70 ",
            "80 ",
            "90 ",
            "100 ",
            "110 ",
            "120 ",
            "130 ",
            "140 ",
            "150 ",
            "160"});
            this.listBox1.Location = new System.Drawing.Point(648, 65);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(81, 260);
            this.listBox1.TabIndex = 41;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 764);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxRD1);
            this.Controls.Add(this.textBoxRD2);
            this.Controls.Add(this.textBoxRD3);
            this.Controls.Add(this.textBoxRC1);
            this.Controls.Add(this.textBoxRC2);
            this.Controls.Add(this.textBoxRC3);
            this.Controls.Add(this.labelDiminuari);
            this.Controls.Add(this.labelCresteri);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.treeViewCredit);
            this.Controls.Add(this.treeViewDebit);
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.labelDebit);
            this.Controls.Add(this.button_IntroducereDate);
            this.Controls.Add(this.textBoxSIC);
            this.Controls.Add(this.labelSID);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Cont creditor";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.TreeView treeViewCredit;
        public System.Windows.Forms.TreeView treeViewDebit;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.Label labelDebit;
        private System.Windows.Forms.Button button_IntroducereDate;
        public System.Windows.Forms.TextBox textBoxSIC;
        private System.Windows.Forms.Label labelSID;
        private System.Windows.Forms.Label labelCresteri;
        private System.Windows.Forms.Label labelDiminuari;
        public System.Windows.Forms.TextBox textBoxRC1;
        public System.Windows.Forms.TextBox textBoxRC2;
        public System.Windows.Forms.TextBox textBoxRC3;
        public System.Windows.Forms.TextBox textBoxRD3;
        public System.Windows.Forms.TextBox textBoxRD2;
        public System.Windows.Forms.TextBox textBoxRD1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fișierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareDateÎnFișierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimareToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}