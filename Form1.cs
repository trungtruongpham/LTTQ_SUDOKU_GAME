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
using System.Threading;
namespace SudokuG
{
    public partial class Form1 : Form
    {
        #region Properties
        BoardGameManager BoardGame;
        int mode = 0;
        #endregion
        public Form1()
        {
            InitializeComponent();
            BoardGame = new BoardGameManager(GameBoard);
            BoardGame.createBoard();
        }

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
        #endregion

        #region MenuStrip-Menu
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                NewGameNormal();
            }
            else
            {
                SecondLabel.Text = "00";
                MinuteLabel.Text = "10";
                HourLabel.Text = "00";
                BoardGame.ClearSudoku();
                BoardGame.CreateSudoku(BoardGame.numofEmpty);

                timer1.Stop();
                timer2.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = BoardGame.currentX;
            int y = BoardGame.currentY;
            if (BoardGame.b[x][y].ForeColor == Color.FromName("Black"))
            {
                BoardGame.b[x][y].Text = " ";
            }
            else
                MessageBox.Show("You must point to the box to delete !");
        }

        #endregion

        #region MenuStrip-Mode
        private void NewGameNormal()
        {
            BoardGame.ClearSudoku();
            BoardGame.CreateSudoku(BoardGame.numofEmpty);

            //Reset đồng hồ mỗi khi new game
            timer1.Start();
            timer2.Stop();
            SecondLabel.Text = "00";
            MinuteLabel.Text = "00";
            HourLabel.Text = "00";

            pictureBox1.Visible = true;
        }

        private void easyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BoardGame.numofEmpty = 40;
            NewGameNormal();
            mode = 1;
        }

        private void mediumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BoardGame.numofEmpty = 50;
            NewGameNormal();
            mode = 1;
        }

        private void hardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BoardGame.numofEmpty = 60;
            NewGameNormal();
            mode = 1; 
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondLabel.Text = "00";
            MinuteLabel.Text = "10";
            HourLabel.Text = "00";
            BoardGame.ClearSudoku();
            BoardGame.CreateSudoku(BoardGame.numofEmpty);
            mode = 2;

            timer1.Stop();
            timer2.Start();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            int sec = int.Parse(SecondLabel.Text);
            int min = int.Parse(MinuteLabel.Text);
            int hour = int.Parse(HourLabel.Text);
            if (sec == 0)
            {
                sec = 59;
                min--;
            }
            sec--;
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

            if (min == 0 && sec == 0)
            {
                timer2.Stop();
                if (BoardGame.checkGameCompleted())
                    MessageBox.Show("Cogratulation, You are winner!!!");
                else
                    MessageBox.Show("Sorry, You failed.");
            }

        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondLabel.Text = "00";
            MinuteLabel.Text = "05";
            HourLabel.Text = "00";
            BoardGame.ClearSudoku();
            BoardGame.CreateSudoku(BoardGame.numofEmpty);
            mode = 2;

            timer1.Stop();
            timer2.Start();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondLabel.Text = "00";
            MinuteLabel.Text = "03";
            HourLabel.Text = "00";
            BoardGame.ClearSudoku();
            BoardGame.CreateSudoku(BoardGame.numofEmpty);
            mode = 2;

            timer1.Stop();
            timer2.Start();
        }
        #endregion

        #region MenuStrip-Help
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sudoku Game version 1.0");
        }
        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complete the Sudoku puzzle so that each and every row, column, and region contains the numbers one through nine only once.");
        }
        #endregion

        #region ToolStrip
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem giá trị nhập vào có đúng không
            if (BoardGame.checkInput() == false)
                MessageBox.Show("You entered wrong !");
            //Kiểm tra xem người chơi đã chiến thắng chưa
            if (BoardGame.checkGameCompleted())
            {
                //Thay hình ảnh khi thắng
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                DialogResult result = MessageBox.Show("Game completed ! Do you want to continue play new game ?", "Notification", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    //Tạo game mới và reset đồng hồ
                    BoardGame.ClearSudoku();
                    BoardGame.CreateSudoku(BoardGame.numofEmpty);
                    timer1.Start();

                    pictureBox2.Visible = false;
                    pictureBox1.Visible = true;
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            BoardGame.Solve();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BoardGame.ImportData();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            BoardGame.Export();
        }
        #endregion

    }
}
