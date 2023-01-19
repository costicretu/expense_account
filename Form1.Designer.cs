
namespace Proiect
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCont = new System.Windows.Forms.Label();
            this.labelTipCont = new System.Windows.Forms.Label();
            this.textBoxCont = new System.Windows.Forms.TextBox();
            this.comboBoxTipCont = new System.Windows.Forms.ComboBox();
            this.button_IntroducereCont = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fișierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazăDateleÎnFișierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCont
            // 
            this.labelCont.AutoSize = true;
            this.labelCont.Location = new System.Drawing.Point(45, 74);
            this.labelCont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCont.Name = "labelCont";
            this.labelCont.Size = new System.Drawing.Size(48, 17);
            this.labelCont.TabIndex = 0;
            this.labelCont.Text = "Contul";
            // 
            // labelTipCont
            // 
            this.labelTipCont.AutoSize = true;
            this.labelTipCont.Location = new System.Drawing.Point(55, 112);
            this.labelTipCont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipCont.Name = "labelTipCont";
            this.labelTipCont.Size = new System.Drawing.Size(39, 17);
            this.labelTipCont.TabIndex = 2;
            this.labelTipCont.Text = "Tipul";
            // 
            // textBoxCont
            // 
            this.textBoxCont.AllowDrop = true;
            this.textBoxCont.Location = new System.Drawing.Point(103, 65);
            this.textBoxCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCont.Name = "textBoxCont";
            this.textBoxCont.Size = new System.Drawing.Size(160, 22);
            this.textBoxCont.TabIndex = 3;
            // 
            // comboBoxTipCont
            // 
            this.comboBoxTipCont.FormattingEnabled = true;
            this.comboBoxTipCont.Items.AddRange(new object[] {
            "Activ",
            "Pasiv"});
            this.comboBoxTipCont.Location = new System.Drawing.Point(103, 108);
            this.comboBoxTipCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTipCont.Name = "comboBoxTipCont";
            this.comboBoxTipCont.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTipCont.TabIndex = 4;
            // 
            // button_IntroducereCont
            // 
            this.button_IntroducereCont.Location = new System.Drawing.Point(103, 158);
            this.button_IntroducereCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_IntroducereCont.Name = "button_IntroducereCont";
            this.button_IntroducereCont.Size = new System.Drawing.Size(161, 28);
            this.button_IntroducereCont.TabIndex = 5;
            this.button_IntroducereCont.Text = "&Introduceți contul";
            this.button_IntroducereCont.UseVisualStyleBackColor = true;
            this.button_IntroducereCont.Click += new System.EventHandler(this.button_IntroducereCont_Click);
            // 
            // printDocument1
            // 
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fișierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(356, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fișierToolStripMenuItem
            // 
            this.fișierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazăDateleÎnFișierToolStripMenuItem,
            this.imprimareToolStripMenuItem});
            this.fișierToolStripMenuItem.Name = "fișierToolStripMenuItem";
            this.fișierToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fișierToolStripMenuItem.Text = "Fișier";
            // 
            // salveazăDateleÎnFișierToolStripMenuItem
            // 
            this.salveazăDateleÎnFișierToolStripMenuItem.Name = "salveazăDateleÎnFișierToolStripMenuItem";
            this.salveazăDateleÎnFișierToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.salveazăDateleÎnFișierToolStripMenuItem.Text = "Salvare date în fișier";
            this.salveazăDateleÎnFișierToolStripMenuItem.Click += new System.EventHandler(this.salveazăDateleÎnFișierToolStripMenuItem_Click);
            // 
            // imprimareToolStripMenuItem
            // 
            this.imprimareToolStripMenuItem.Name = "imprimareToolStripMenuItem";
            this.imprimareToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.imprimareToolStripMenuItem.Text = "Imprimare";
            this.imprimareToolStripMenuItem.Click += new System.EventHandler(this.imprimareToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 241);
            this.Controls.Add(this.button_IntroducereCont);
            this.Controls.Add(this.comboBoxTipCont);
            this.Controls.Add(this.textBoxCont);
            this.Controls.Add(this.labelTipCont);
            this.Controls.Add(this.labelCont);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Operații contabile";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCont;
        private System.Windows.Forms.Label labelTipCont;
        public System.Windows.Forms.TextBox textBoxCont;
        public System.Windows.Forms.ComboBox comboBoxTipCont;
        private System.Windows.Forms.Button button_IntroducereCont;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fișierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazăDateleÎnFișierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimareToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

