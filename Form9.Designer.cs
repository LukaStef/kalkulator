namespace patnja
{
    partial class UglKal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UglKal));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAC = new System.Windows.Forms.Button();
            this.radioButtonK = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.uputstvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 135);
            this.panel3.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(121, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 129);
            this.panel1.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.buttonAC);
            this.groupBox2.Controls.Add(this.radioButtonK);
            this.groupBox2.Controls.Add(this.radioButtonC);
            this.groupBox2.Controls.Add(this.radioButtonF);
            this.groupBox2.Location = new System.Drawing.Point(-1, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 129);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jedinice";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(54, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pretvori";
            this.toolTip1.SetToolTip(this.button1, "Pretvara ugao izabrane jedinice u sve ostale jedinice");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAC
            // 
            this.buttonAC.BackColor = System.Drawing.Color.White;
            this.buttonAC.Location = new System.Drawing.Point(54, 82);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(75, 39);
            this.buttonAC.TabIndex = 8;
            this.buttonAC.Text = "AC";
            this.toolTip1.SetToolTip(this.buttonAC, "Resetuje sve vrednosti i čisti kutiju za unos");
            this.buttonAC.UseVisualStyleBackColor = false;
            this.buttonAC.Click += new System.EventHandler(this.buttonAC_Click);
            // 
            // radioButtonK
            // 
            this.radioButtonK.AutoSize = true;
            this.radioButtonK.Location = new System.Drawing.Point(10, 99);
            this.radioButtonK.Name = "radioButtonK";
            this.radioButtonK.Size = new System.Drawing.Size(49, 19);
            this.radioButtonK.TabIndex = 11;
            this.radioButtonK.Text = "grad";
            this.toolTip1.SetToolTip(this.radioButtonK, "Omogućava unos uglova u gradijanima");
            this.radioButtonK.UseVisualStyleBackColor = true;
            this.radioButtonK.CheckedChanged += new System.EventHandler(this.radioButtonK_CheckedChanged);
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Checked = true;
            this.radioButtonC.Location = new System.Drawing.Point(10, 23);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(30, 19);
            this.radioButtonC.TabIndex = 9;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "°";
            this.toolTip1.SetToolTip(this.radioButtonC, "Omogućava unos uglova u stepenima");
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.CheckedChanged += new System.EventHandler(this.radioButtonC_CheckedChanged);
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(10, 61);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(42, 19);
            this.radioButtonF.TabIndex = 10;
            this.radioButtonF.Text = "rad";
            this.toolTip1.SetToolTip(this.radioButtonF, "Omogućava unos uglova u radijanima");
            this.radioButtonF.UseVisualStyleBackColor = true;
            this.radioButtonF.CheckedChanged += new System.EventHandler(this.radioButtonF_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 129);
            this.panel2.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxD);
            this.groupBox1.Controls.Add(this.textBoxR);
            this.groupBox1.Controls.Add(this.textBoxG);
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 129);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos i ispis";
            // 
            // textBoxD
            // 
            this.textBoxD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxD.Location = new System.Drawing.Point(6, 22);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(100, 23);
            this.textBoxD.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxD, "Ugao u stepenima");
            // 
            // textBoxR
            // 
            this.textBoxR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxR.Location = new System.Drawing.Point(6, 60);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.Size = new System.Drawing.Size(100, 23);
            this.textBoxR.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxR, "Ugao u radijanima");
            // 
            // textBoxG
            // 
            this.textBoxG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxG.Location = new System.Drawing.Point(6, 98);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.ReadOnly = true;
            this.textBoxG.Size = new System.Drawing.Size(100, 23);
            this.textBoxG.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxG, "Ugao u gradijanima");
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
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.oAplikacijiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uputstvoToolStripMenuItem});
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.oAplikacijiToolStripMenuItem.Text = "O aplikaciji";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikacijiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(261, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // UglKal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 159);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(277, 198);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(277, 198);
            this.Name = "UglKal";
            this.Text = "Kalkulator uglova";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private GroupBox groupBox2;
        private Button button1;
        private ToolTip toolTip1;
        private Button buttonAC;
        private RadioButton radioButtonK;
        private RadioButton radioButtonC;
        private RadioButton radioButtonF;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox textBoxD;
        private TextBox textBoxR;
        private TextBox textBoxG;
        private ToolStripMenuItem uputstvoToolStripMenuItem;
        private ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}