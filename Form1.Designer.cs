namespace ImageProcessing2
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
            this.groupBox1SizeMode = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeinvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.channelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.transformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirroringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scalingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBoxOrijinal = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxAnalyze = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelAvalue = new System.Windows.Forms.Label();
            this.labelBValue = new System.Windows.Forms.Label();
            this.labelGValue = new System.Windows.Forms.Label();
            this.labelRValue = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.groupBox1SizeMode.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxOrijinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxAnalyze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1SizeMode
            // 
            this.groupBox1SizeMode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1SizeMode.Controls.Add(this.groupBox3);
            this.groupBox1SizeMode.Controls.Add(this.groupBox2);
            this.groupBox1SizeMode.Location = new System.Drawing.Point(2, 3);
            this.groupBox1SizeMode.Name = "groupBox1SizeMode";
            this.groupBox1SizeMode.Size = new System.Drawing.Size(210, 526);
            this.groupBox1SizeMode.TabIndex = 0;
            this.groupBox1SizeMode.TabStop = false;
            this.groupBox1SizeMode.Text = "Progress";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.menuStrip1);
            this.groupBox3.Controls.Add(this.menuStrip2);
            this.groupBox3.Controls.Add(this.menuStrip3);
            this.groupBox3.Location = new System.Drawing.Point(6, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 91);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Analyze";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analyzeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(194, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // analyzeToolStripMenuItem
            // 
            this.analyzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem,
            this.negativeinvertToolStripMenuItem,
            this.grayScaleToolStripMenuItem});
            this.analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            this.analyzeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.analyzeToolStripMenuItem.Text = "Analyze";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // negativeinvertToolStripMenuItem
            // 
            this.negativeinvertToolStripMenuItem.Name = "negativeinvertToolStripMenuItem";
            this.negativeinvertToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.negativeinvertToolStripMenuItem.Text = "Negative-invert";
            this.negativeinvertToolStripMenuItem.Click += new System.EventHandler(this.negativeinvertToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.grayScaleToolStripMenuItem.Text = "Gray scale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.channelsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 40);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(194, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // channelsToolStripMenuItem
            // 
            this.channelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.channelsToolStripMenuItem.Name = "channelsToolStripMenuItem";
            this.channelsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.channelsToolStripMenuItem.Text = "Channels";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transformationToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(3, 64);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(194, 24);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // transformationToolStripMenuItem
            // 
            this.transformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mirroringToolStripMenuItem,
            this.rotationToolStripMenuItem,
            this.scalingToolStripMenuItem});
            this.transformationToolStripMenuItem.Name = "transformationToolStripMenuItem";
            this.transformationToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.transformationToolStripMenuItem.Text = "Transformation";
            // 
            // mirroringToolStripMenuItem
            // 
            this.mirroringToolStripMenuItem.Name = "mirroringToolStripMenuItem";
            this.mirroringToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.mirroringToolStripMenuItem.Text = "Mirroring";
            // 
            // rotationToolStripMenuItem
            // 
            this.rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            this.rotationToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.rotationToolStripMenuItem.Text = "Rotation";
            // 
            // scalingToolStripMenuItem
            // 
            this.scalingToolStripMenuItem.Name = "scalingToolStripMenuItem";
            this.scalingToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.scalingToolStripMenuItem.Text = "Scaling";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonReset);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Controls.Add(this.buttonOpen);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 83);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Open File";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonReset.Location = new System.Drawing.Point(113, 33);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reopen";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSave.Location = new System.Drawing.Point(15, 49);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonOpen.Location = new System.Drawing.Point(15, 19);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(84, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // groupBoxOrijinal
            // 
            this.groupBoxOrijinal.Controls.Add(this.pictureBox1);
            this.groupBoxOrijinal.Location = new System.Drawing.Point(218, 2);
            this.groupBoxOrijinal.Name = "groupBoxOrijinal";
            this.groupBoxOrijinal.Size = new System.Drawing.Size(324, 257);
            this.groupBoxOrijinal.TabIndex = 1;
            this.groupBoxOrijinal.TabStop = false;
            this.groupBoxOrijinal.Text = "Orijinal image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 231);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // groupBoxAnalyze
            // 
            this.groupBoxAnalyze.Controls.Add(this.pictureBox2);
            this.groupBoxAnalyze.Location = new System.Drawing.Point(566, 3);
            this.groupBoxAnalyze.Name = "groupBoxAnalyze";
            this.groupBoxAnalyze.Size = new System.Drawing.Size(324, 257);
            this.groupBoxAnalyze.TabIndex = 2;
            this.groupBoxAnalyze.TabStop = false;
            this.groupBoxAnalyze.Text = "SelectedAnalyze";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 231);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.labelA);
            this.groupBox1.Controls.Add(this.labelB);
            this.groupBox1.Controls.Add(this.labelG);
            this.groupBox1.Controls.Add(this.labelR);
            this.groupBox1.Controls.Add(this.labelAvalue);
            this.groupBox1.Controls.Add(this.labelBValue);
            this.groupBox1.Controls.Add(this.labelGValue);
            this.groupBox1.Controls.Add(this.labelRValue);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Location = new System.Drawing.Point(959, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histogram";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(123, 94);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(34, 13);
            this.labelA.TabIndex = 8;
            this.labelA.Text = "Alpha";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(123, 70);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(28, 13);
            this.labelB.TabIndex = 7;
            this.labelB.Text = "Blue";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(123, 44);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(36, 13);
            this.labelG.TabIndex = 6;
            this.labelG.Text = "Green";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(123, 20);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(27, 13);
            this.labelR.TabIndex = 5;
            this.labelR.Text = "Red";
            // 
            // labelAvalue
            // 
            this.labelAvalue.AutoSize = true;
            this.labelAvalue.Location = new System.Drawing.Point(173, 94);
            this.labelAvalue.Name = "labelAvalue";
            this.labelAvalue.Size = new System.Drawing.Size(13, 13);
            this.labelAvalue.TabIndex = 4;
            this.labelAvalue.Text = "0";
            // 
            // labelBValue
            // 
            this.labelBValue.AutoSize = true;
            this.labelBValue.Location = new System.Drawing.Point(173, 70);
            this.labelBValue.Name = "labelBValue";
            this.labelBValue.Size = new System.Drawing.Size(13, 13);
            this.labelBValue.TabIndex = 3;
            this.labelBValue.Text = "0";
            // 
            // labelGValue
            // 
            this.labelGValue.AutoSize = true;
            this.labelGValue.Location = new System.Drawing.Point(173, 44);
            this.labelGValue.Name = "labelGValue";
            this.labelGValue.Size = new System.Drawing.Size(13, 13);
            this.labelGValue.TabIndex = 2;
            this.labelGValue.Text = "0";
            // 
            // labelRValue
            // 
            this.labelRValue.AutoSize = true;
            this.labelRValue.Location = new System.Drawing.Point(173, 19);
            this.labelRValue.Name = "labelRValue";
            this.labelRValue.Size = new System.Drawing.Size(13, 13);
            this.labelRValue.TabIndex = 1;
            this.labelRValue.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(6, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 48);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxRed);
            this.groupBox4.Location = new System.Drawing.Point(913, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 256);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Red";
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.Location = new System.Drawing.Point(11, 19);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(302, 231);
            this.pictureBoxRed.TabIndex = 0;
            this.pictureBoxRed.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxGreen);
            this.groupBox5.Location = new System.Drawing.Point(218, 272);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(324, 257);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Green";
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.Location = new System.Drawing.Point(10, 20);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(302, 231);
            this.pictureBoxGreen.TabIndex = 1;
            this.pictureBoxGreen.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBoxBlue);
            this.groupBox6.Location = new System.Drawing.Point(566, 272);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(324, 257);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Blue";
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.Location = new System.Drawing.Point(11, 20);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(302, 231);
            this.pictureBoxBlue.TabIndex = 1;
            this.pictureBoxBlue.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 531);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxAnalyze);
            this.Controls.Add(this.groupBoxOrijinal);
            this.Controls.Add(this.groupBox1SizeMode);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Processing ";
            this.groupBox1SizeMode.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxOrijinal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxAnalyze.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1SizeMode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeinvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem channelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.GroupBox groupBoxOrijinal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxAnalyze;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem transformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirroringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scalingToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelAvalue;
        private System.Windows.Forms.Label labelBValue;
        private System.Windows.Forms.Label labelGValue;
        private System.Windows.Forms.Label labelRValue;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
    }
}

