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
        #region ImportExportFile
        private void ImportBtn_Click(object sender, EventArgs e)
        {
            BoardGame.ImportData();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            BoardGame.Export();
        }
        #endregion

        #region Function
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

        private void SolveBtn_Click(object sender, EventArgs e)
        {
            BoardGame.Solve();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int sec = int.Parse(SecondLabel.Text);
            int min = int.Parse(MinuteLabel.Text);
            int hour = int.Parse(HourLabel.Text);
            sec++;
            //Tăng phút khi được 60s
            if (sec >= 60)
            {
                min++;
                sec -= 60;
            }
            //Tăng giờ khi được 60p
            if (min >= 60)
            {
                min -= 60;
                hour++;
            }
            //Chuyển dữ liệu vào label sau khi thời gian được chuẩn hóa
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
            //Kiểm tra xem giá trị nhập vào có đúng không
            if (BoardGame.checkInput() == false)
                MessageBox.Show("Ban da nhap sai !");
            //Kiểm tra xem người chơi đã chiến thắng chưa
            if (BoardGame.checkGameCompleted())
            {
                DialogResult result = MessageBox.Show("Game completed ! ", "Thông báo", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    BoardGame.ClearSudoku();
                    BoardGame.CreateSudoku(BoardGame.numofEmpty);
                    timer1.Start();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
        #endregion

        #region MenuStrip
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoardGame.ClearSudoku();
            BoardGame.CreateSudoku(BoardGame.numofEmpty);
            timer1.Start();
        }
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sudoku Game version 1.0");
        }

        private void easyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BoardGame.numofEmpty = 20;
        }

        private void mediumToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BoardGame.numofEmpty = 40;
        }

        private void hardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BoardGame.numofEmpty = 60;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = BoardGame.currentX;
            int y = BoardGame.currentY;
            BoardGame.b[x][y].Text = " ";
        }
        #endregion
    }
}
