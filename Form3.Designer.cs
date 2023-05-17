namespace patnja
{
    partial class KompKal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KompKal));
            this.buttonIZR = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxREZ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonMODUO = new System.Windows.Forms.RadioButton();
            this.radioButtonARG = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uputstvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxISPIS = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonRAD = new System.Windows.Forms.RadioButton();
            this.radioButtonDEG = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIZR
            // 
            this.buttonIZR.BackColor = System.Drawing.Color.White;
            this.buttonIZR.Location = new System.Drawing.Point(84, 136);
            this.buttonIZR.Name = "buttonIZR";
            this.buttonIZR.Size = new System.Drawing.Size(62, 23);
            this.buttonIZR.TabIndex = 0;
            this.buttonIZR.Text = "Izračunaj";
            this.toolTip1.SetToolTip(this.buttonIZR, "Vrši operaciju");
            this.buttonIZR.UseVisualStyleBackColor = false;
            this.buttonIZR.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxR.Location = new System.Drawing.Point(46, 22);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 23);
            this.textBoxR.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxR, "Realni deo broja");
            // 
            // textBoxI
            // 
            this.textBoxI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxI.Location = new System.Drawing.Point(46, 51);
            this.textBoxI.Name = "textBoxI";
            this.textBoxI.Size = new System.Drawing.Size(100, 23);
            this.textBoxI.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxI, "Imaginarni deo broja");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rez.";
            // 
            // textBoxREZ
            // 
            this.textBoxREZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxREZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxREZ.Location = new System.Drawing.Point(46, 109);
            this.textBoxREZ.Name = "textBoxREZ";
            this.textBoxREZ.ReadOnly = true;
            this.textBoxREZ.Size = new System.Drawing.Size(100, 23);
            this.textBoxREZ.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxREZ, "Rezultat izabrane operacije");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Real";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Imag";
            // 
            // radioButtonMODUO
            // 
            this.radioButtonMODUO.AutoSize = true;
            this.radioButtonMODUO.Checked = true;
            this.radioButtonMODUO.Location = new System.Drawing.Point(6, 22);
            this.radioButtonMODUO.Name = "radioButtonMODUO";
            this.radioButtonMODUO.Size = new System.Drawing.Size(64, 19);
            this.radioButtonMODUO.TabIndex = 7;
            this.radioButtonMODUO.TabStop = true;
            this.radioButtonMODUO.Tag = "";
            this.radioButtonMODUO.Text = "Moduo";
            this.toolTip1.SetToolTip(this.radioButtonMODUO, "Računa dužinu vektora na brojevnoj skali");
            this.radioButtonMODUO.UseVisualStyleBackColor = true;
            // 
            // radioButtonARG
            // 
            this.radioButtonARG.AutoSize = true;
            this.radioButtonARG.Location = new System.Drawing.Point(6, 47);
            this.radioButtonARG.Name = "radioButtonARG";
            this.radioButtonARG.Size = new System.Drawing.Size(79, 19);
            this.radioButtonARG.TabIndex = 8;
            this.radioButtonARG.Tag = "";
            this.radioButtonARG.Text = "Argument";
            this.toolTip1.SetToolTip(this.radioButtonARG, "Računa ugao vektora na brojevnoj skali");
            this.radioButtonARG.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikacijiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(266, 24);
            this.menuStrip1.TabIndex = 9;
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
            // textBoxISPIS
            // 
            this.textBoxISPIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxISPIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxISPIS.Location = new System.Drawing.Point(46, 80);
            this.textBoxISPIS.Name = "textBoxISPIS";
            this.textBoxISPIS.ReadOnly = true;
            this.textBoxISPIS.Size = new System.Drawing.Size(100, 23);
            this.textBoxISPIS.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxISPIS, "Prikaz celog kompleksnog broja");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonARG);
            this.groupBox1.Controls.Add(this.radioButtonMODUO);
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 78);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operacija";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonRAD);
            this.groupBox2.Controls.Add(this.radioButtonDEG);
            this.groupBox2.Location = new System.Drawing.Point(-1, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 78);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jedinica";
            // 
            // radioButtonRAD
            // 
            this.radioButtonRAD.AutoSize = true;
            this.radioButtonRAD.Location = new System.Drawing.Point(6, 47);
            this.radioButtonRAD.Name = "radioButtonRAD";
            this.radioButtonRAD.Size = new System.Drawing.Size(48, 19);
            this.radioButtonRAD.TabIndex = 1;
            this.radioButtonRAD.Text = "RAD";
            this.toolTip1.SetToolTip(this.radioButtonRAD, "Režim radijana za argument");
            this.radioButtonRAD.UseVisualStyleBackColor = true;
            // 
            // radioButtonDEG
            // 
            this.radioButtonDEG.AutoSize = true;
            this.radioButtonDEG.Checked = true;
            this.radioButtonDEG.Location = new System.Drawing.Point(6, 22);
            this.radioButtonDEG.Name = "radioButtonDEG";
            this.radioButtonDEG.Size = new System.Drawing.Size(47, 19);
            this.radioButtonDEG.TabIndex = 0;
            this.radioButtonDEG.TabStop = true;
            this.radioButtonDEG.Text = "DEG";
            this.toolTip1.SetToolTip(this.radioButtonDEG, "Režim stepena za argument");
            this.radioButtonDEG.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "AC";
            this.toolTip1.SetToolTip(this.button2, "Resetuje sve vrednosti i čisti kutiju za unos");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 168);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(172, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(91, 78);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(172, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(91, 78);
            this.panel4.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 162);
            this.panel2.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxR);
            this.groupBox3.Controls.Add(this.buttonIZR);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBoxI);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxREZ);
            this.groupBox3.Controls.Add(this.textBoxISPIS);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(-1, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 162);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unos i ispis";
            // 
            // KompKal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 192);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(282, 231);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(282, 231);
            this.Name = "KompKal";
            this.Text = "Kompleksni kalkulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonIZR;
        private TextBox textBoxR;
        private TextBox textBoxI;
        private Label label1;
        private TextBox textBoxREZ;
        private Label label2;
        private Label label3;
        private RadioButton radioButtonMODUO;
        private RadioButton radioButtonARG;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private ToolStripMenuItem uputstvoToolStripMenuItem;
        private TextBox textBoxISPIS;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButtonRAD;
        private RadioButton radioButtonDEG;
        private Button button2;
        private ToolTip toolTip1;
        private Panel panel1;
        private GroupBox groupBox3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}