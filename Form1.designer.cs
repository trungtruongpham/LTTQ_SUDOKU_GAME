namespace SudokuG
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.input9 = new System.Windows.Forms.Button();
            this.input8 = new System.Windows.Forms.Button();
            this.input7 = new System.Windows.Forms.Button();
            this.input6 = new System.Windows.Forms.Button();
            this.input5 = new System.Windows.Forms.Button();
            this.input4 = new System.Windows.Forms.Button();
            this.input3 = new System.Windows.Forms.Button();
            this.input2 = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Button();
            this.GameBoard = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.levelToolStripMenuItem,
            this.toolStripSeparator2,
            this.undoToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.toolStripSeparator3,
            this.mediumToolStripMenuItem,
            this.toolStripSeparator4,
            this.hardToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.levelToolStripMenuItem.Text = "Level";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(116, 6);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(116, 6);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(148, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.input9);
            this.panel1.Controls.Add(this.input8);
            this.panel1.Controls.Add(this.input7);
            this.panel1.Controls.Add(this.input6);
            this.panel1.Controls.Add(this.input5);
            this.panel1.Controls.Add(this.input4);
            this.panel1.Controls.Add(this.input3);
            this.panel1.Controls.Add(this.input2);
            this.panel1.Controls.Add(this.input1);
            this.panel1.Controls.Add(this.input);
            this.panel1.Location = new System.Drawing.Point(552, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 194);
            this.panel1.TabIndex = 5;
            // 
            // input9
            // 
            this.input9.Location = new System.Drawing.Point(75, 119);
            this.input9.Name = "input9";
            this.input9.Size = new System.Drawing.Size(37, 23);
            this.input9.TabIndex = 9;
            this.input9.Text = "9";
            this.input9.UseVisualStyleBackColor = true;
            this.input9.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // input8
            // 
            this.input8.Location = new System.Drawing.Point(75, 90);
            this.input8.Name = "input8";
            this.input8.Size = new System.Drawing.Size(37, 23);
            this.input8.TabIndex = 8;
            this.input8.Text = "8";
            this.input8.UseVisualStyleBackColor = true;
            this.input8.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // input7
            // 
            this.input7.Location = new System.Drawing.Point(75, 61);
            this.input7.Name = "input7";
            this.input7.Size = new System.Drawing.Size(37, 23);
            this.input7.TabIndex = 7;
            this.input7.Text = "7";
            this.input7.UseVisualStyleBackColor = true;
            this.input7.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // input6
            // 
            this.input6.Location = new System.Drawing.Point(75, 32);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(37, 23);
            this.input6.TabIndex = 6;
            this.input6.Text = "6";
            this.input6.UseVisualStyleBackColor = true;
            this.input6.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // input5
            // 
            this.input5.Location = new System.Drawing.Point(12, 148);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(37, 23);
            this.input5.TabIndex = 5;
            this.input5.Text = "5";
            this.input5.UseVisualStyleBackColor = true;
            this.input5.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(12, 119);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(37, 23);
            this.input4.TabIndex = 4;
            this.input4.Text = "4";
            this.input4.UseVisualStyleBackColor = true;
            this.input4.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(12, 90);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(37, 23);
            this.input3.TabIndex = 3;
            this.input3.Text = "3";
            this.input3.UseVisualStyleBackColor = true;
            this.input3.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(12, 61);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(37, 23);
            this.input2.TabIndex = 2;
            this.input2.Text = "2";
            this.input2.UseVisualStyleBackColor = true;
            this.input2.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(12, 32);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(37, 23);
            this.input1.TabIndex = 1;
            this.input1.Text = "1";
            this.input1.UseVisualStyleBackColor = true;
            this.input1.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(25, 3);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 23);
            this.input.TabIndex = 0;
            this.input.Text = "input";
            this.input.UseVisualStyleBackColor = true;
            // 
            // GameBoard
            // 
            this.GameBoard.Location = new System.Drawing.Point(12, 56);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(531, 409);
            this.GameBoard.TabIndex = 6;
            this.GameBoard.TabStop = false;
            this.GameBoard.Text = "Sudoku";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.Location = new System.Drawing.Point(580, 55);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(24, 23);
            this.MinuteLabel.TabIndex = 11;
            this.MinuteLabel.Text = "00";
            // 
            // SecondLabel
            // 
            this.SecondLabel.Location = new System.Drawing.Point(612, 56);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(30, 23);
            this.SecondLabel.TabIndex = 12;
            this.SecondLabel.Text = "00";
            // 
            // HourLabel
            // 
            this.HourLabel.Location = new System.Drawing.Point(549, 56);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(26, 23);
            this.HourLabel.TabIndex = 13;
            this.HourLabel.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = ":";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(691, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "Check";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton2.Text = "Solve";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton3.Text = "Import";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton4.Text = "Export";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 477);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.GameBoard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button input9;
        private System.Windows.Forms.Button input8;
        private System.Windows.Forms.Button input7;
        private System.Windows.Forms.Button input6;
        private System.Windows.Forms.Button input5;
        private System.Windows.Forms.Button input4;
        private System.Windows.Forms.Button input3;
        private System.Windows.Forms.Button input2;
        private System.Windows.Forms.Button input1;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.GroupBox GameBoard;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

