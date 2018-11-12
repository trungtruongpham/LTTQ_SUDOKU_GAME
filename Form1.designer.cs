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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
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
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Level";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(471, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Check";
            this.button3.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(471, 163);
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
            this.GameBoard.Location = new System.Drawing.Point(12, 27);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(443, 363);
            this.GameBoard.TabIndex = 6;
            this.GameBoard.TabStop = false;
            this.GameBoard.Text = "groupBox1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(552, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Solve";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.Location = new System.Drawing.Point(501, 111);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(23, 23);
            this.MinuteLabel.TabIndex = 11;
            this.MinuteLabel.Text = "00";
            // 
            // SecondLabel
            // 
            this.SecondLabel.Location = new System.Drawing.Point(530, 111);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(33, 23);
            this.SecondLabel.TabIndex = 12;
            this.SecondLabel.Text = "00";
            // 
            // HourLabel
            // 
            this.HourLabel.Location = new System.Drawing.Point(471, 111);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(24, 23);
            this.HourLabel.TabIndex = 13;
            this.HourLabel.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 458);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.GameBoard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label HourLabel;
    }
}

