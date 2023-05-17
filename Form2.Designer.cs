namespace patnja
{
    partial class LogKal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogKal));
            this.textBoxo = new System.Windows.Forms.TextBox();
            this.textBoxc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.buttonAND = new System.Windows.Forms.Button();
            this.buttonNAND = new System.Windows.Forms.Button();
            this.buttonXAND = new System.Windows.Forms.Button();
            this.buttonXOR = new System.Windows.Forms.Button();
            this.buttonNOR = new System.Windows.Forms.Button();
            this.buttonOR = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uputstvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxo
            // 
            this.textBoxo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxo.Location = new System.Drawing.Point(82, 42);
            this.textBoxo.Name = "textBoxo";
            this.textBoxo.ReadOnly = true;
            this.textBoxo.Size = new System.Drawing.Size(48, 23);
            this.textBoxo.TabIndex = 3;
            this.textBoxo.Text = "AND";
            this.toolTip1.SetToolTip(this.textBoxo, "Logička operacija");
            // 
            // textBoxc
            // 
            this.textBoxc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxc.Location = new System.Drawing.Point(140, 42);
            this.textBoxc.Name = "textBoxc";
            this.textBoxc.ReadOnly = true;
            this.textBoxc.Size = new System.Drawing.Size(23, 23);
            this.textBoxc.TabIndex = 4;
            this.textBoxc.Text = "0";
            this.toolTip1.SetToolTip(this.textBoxc, "Rezultat operacije");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "C";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.numericUpDownA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownA.Location = new System.Drawing.Point(36, 22);
            this.numericUpDownA.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.ReadOnly = true;
            this.numericUpDownA.Size = new System.Drawing.Size(35, 23);
            this.numericUpDownA.TabIndex = 15;
            this.toolTip1.SetToolTip(this.numericUpDownA, "Logička vrednost A");
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.numericUpDownB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownB.Location = new System.Drawing.Point(36, 61);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.ReadOnly = true;
            this.numericUpDownB.Size = new System.Drawing.Size(35, 23);
            this.numericUpDownB.TabIndex = 16;
            this.toolTip1.SetToolTip(this.numericUpDownB, "Logička vrednost B");
            // 
            // buttonAND
            // 
            this.buttonAND.BackColor = System.Drawing.Color.White;
            this.buttonAND.Location = new System.Drawing.Point(13, 31);
            this.buttonAND.Name = "buttonAND";
            this.buttonAND.Size = new System.Drawing.Size(53, 23);
            this.buttonAND.TabIndex = 18;
            this.buttonAND.Text = "AND";
            this.toolTip1.SetToolTip(this.buttonAND, "Operacija AND");
            this.buttonAND.UseVisualStyleBackColor = false;
            this.buttonAND.Click += new System.EventHandler(this.buttonAND_Click);
            // 
            // buttonNAND
            // 
            this.buttonNAND.BackColor = System.Drawing.Color.White;
            this.buttonNAND.Location = new System.Drawing.Point(72, 31);
            this.buttonNAND.Name = "buttonNAND";
            this.buttonNAND.Size = new System.Drawing.Size(53, 23);
            this.buttonNAND.TabIndex = 23;
            this.buttonNAND.Text = "NAND";
            this.toolTip1.SetToolTip(this.buttonNAND, "Operacija NAND");
            this.buttonNAND.UseVisualStyleBackColor = false;
            this.buttonNAND.Click += new System.EventHandler(this.buttonNAND_Click);
            // 
            // buttonXAND
            // 
            this.buttonXAND.BackColor = System.Drawing.Color.White;
            this.buttonXAND.Location = new System.Drawing.Point(131, 31);
            this.buttonXAND.Name = "buttonXAND";
            this.buttonXAND.Size = new System.Drawing.Size(53, 23);
            this.buttonXAND.TabIndex = 24;
            this.buttonXAND.Text = "XAND";
            this.toolTip1.SetToolTip(this.buttonXAND, "Operacija XAND");
            this.buttonXAND.UseVisualStyleBackColor = false;
            this.buttonXAND.Click += new System.EventHandler(this.buttonXAND_Click);
            // 
            // buttonXOR
            // 
            this.buttonXOR.BackColor = System.Drawing.Color.White;
            this.buttonXOR.Location = new System.Drawing.Point(131, 60);
            this.buttonXOR.Name = "buttonXOR";
            this.buttonXOR.Size = new System.Drawing.Size(53, 23);
            this.buttonXOR.TabIndex = 27;
            this.buttonXOR.Text = "XOR";
            this.toolTip1.SetToolTip(this.buttonXOR, "Operacija XOR");
            this.buttonXOR.UseVisualStyleBackColor = false;
            this.buttonXOR.Click += new System.EventHandler(this.buttonXOR_Click);
            // 
            // buttonNOR
            // 
            this.buttonNOR.BackColor = System.Drawing.Color.White;
            this.buttonNOR.Location = new System.Drawing.Point(72, 60);
            this.buttonNOR.Name = "buttonNOR";
            this.buttonNOR.Size = new System.Drawing.Size(53, 23);
            this.buttonNOR.TabIndex = 26;
            this.buttonNOR.Text = "NOR";
            this.toolTip1.SetToolTip(this.buttonNOR, "Operacija NOR");
            this.buttonNOR.UseVisualStyleBackColor = false;
            this.buttonNOR.Click += new System.EventHandler(this.buttonNOR_Click);
            // 
            // buttonOR
            // 
            this.buttonOR.BackColor = System.Drawing.Color.White;
            this.buttonOR.Location = new System.Drawing.Point(13, 60);
            this.buttonOR.Name = "buttonOR";
            this.buttonOR.Size = new System.Drawing.Size(53, 23);
            this.buttonOR.TabIndex = 25;
            this.buttonOR.Text = "OR";
            this.toolTip1.SetToolTip(this.buttonOR, "Operacija OR");
            this.buttonOR.UseVisualStyleBackColor = false;
            this.buttonOR.Click += new System.EventHandler(this.buttonOR_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikacijiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(206, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.oAplikacijiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uputstvoToolStripMenuItem});
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.oAplikacijiToolStripMenuItem.Text = "O aplikaciji";
            // 
            // uputstvoToolStripMenuItem
            // 
            this.uputstvoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uputstvoToolStripMenuItem.Image")));
            this.uputstvoToolStripMenuItem.Name = "uputstvoToolStripMenuItem";
            this.uputstvoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.uputstvoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.uputstvoToolStripMenuItem.Text = "Uputstvo";
            this.uputstvoToolStripMenuItem.Click += new System.EventHandler(this.uputstvoToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownA);
            this.groupBox1.Controls.Add(this.textBoxo);
            this.groupBox1.Controls.Add(this.textBoxc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownB);
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.MaximumSize = new System.Drawing.Size(200, 100);
            this.groupBox1.MinimumSize = new System.Drawing.Size(200, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ispis";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonXAND);
            this.groupBox2.Controls.Add(this.buttonAND);
            this.groupBox2.Controls.Add(this.buttonXOR);
            this.groupBox2.Controls.Add(this.buttonNAND);
            this.groupBox2.Controls.Add(this.buttonNOR);
            this.groupBox2.Controls.Add(this.buttonOR);
            this.groupBox2.Location = new System.Drawing.Point(-1, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operacije";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 212);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 31;
            // 
            // LogKal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 236);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(222, 275);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(222, 275);
            this.Name = "LogKal";
            this.Text = "Logički kalkulator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxo;
        private TextBox textBoxc;
        private Label label1;
        private Label label2;
        private Label label4;
        private ToolTip toolTip1;
        private NumericUpDown numericUpDownA;
        private NumericUpDown numericUpDownB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private ToolStripMenuItem uputstvoToolStripMenuItem;
        private Button buttonAND;
        private Button buttonNAND;
        private Button buttonXAND;
        private Button buttonXOR;
        private Button buttonNOR;
        private Button buttonOR;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}