using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SudokuG;
namespace SudokuG
{
    public partial class Form1 : Form
    {
        #region Properties
        BoardGameManager BoardGame;
        #endregion
        public Form1()
        {
            InitializeComponent();
            BoardGame = new BoardGameManager(GameBoard);
            BoardGame.createBoard();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BoardGame.ImportData();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoardGame.ClearSudoku();
            BoardGame.CreateSudoku(BoardGame.numofEmpty);
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BoardGame.Export();
        }
        private void buttonInput_Click(object sender, EventArgs e)
        {
            int x = BoardGame.currentX;
            int y = BoardGame.currentY;
            if (x >= 0 && y >= 0 && x <= 8 && y <= 8)
            {
                Button bt = (Button)sender;
                if (bt.Text != "0")
                {
                    BoardGame.b[x][y].Text = bt.Text;
                }
                else
                {
                    BoardGame.b[x][y].Text = " ";
                }
                BoardGame.currentX = -1;
                BoardGame.currentY = -1;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoardGame.numofEmpty = 20;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoardGame.numofEmpty = 40;
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoardGame.numofEmpty = 60;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BoardGame.Solve();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int sec = int.Parse(SecondLabel.Text);
            int min = int.Parse(MinuteLabel.Text);
            int hour = int.Parse(HourLabel.Text);
            sec++;
            //Tang phut khi duoc 60s
            if (sec >= 60)
            {
                min++;
                sec -= 60;
            }
            //Tang gio khi duoc 60p
            if(min >= 60)
            {
                min -= 60;
                hour++;
            }
            //Chuyen du lieu vao label sau khi chuan hoa
            if (sec < 10)
                SecondLabel.Text = "0" + sec;
            else
                SecondLabel.Text = sec.ToString();
            if (sec < 10)
                MinuteLabel.Text = "0" + min;
            else
                MinuteLabel.Text = min.ToString();
            if (hour < 10)
                HourLabel.Text = "0" + hour;
            else
                HourLabel.Text = hour.ToString();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            if (BoardGame.checkInput() == false)
                MessageBox.Show("Ban da nhap sai !");
        }
    }
}
