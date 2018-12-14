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
using System.Resources;
using System.Globalization;
namespace SudokuG
{
    public partial class Form1 : Form
    {
        #region Properties
        BoardGameManager BoardGame;
        int mode = 0;
        CultureInfo culture;
        string[] text = new string[10];
        #endregion
        public Form1()
        {
            InitializeComponent();
            BoardGame = new BoardGameManager(GameBoard);
            BoardGame.createBoard();
            culture = CultureInfo.CurrentCulture;
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
                pictureBox1.Visible = true;

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
            else {
                ResourceManager rm = new ResourceManager("LTTQ_SUDOKU_GAME.Resources.Resource", typeof(Form1).Assembly);
                string message = rm.GetString("you need to indicate the box to delete!", culture);
                MessageBox.Show(message);
            }
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
                ResourceManager rm = new ResourceManager("LTTQ_SUDOKU_GAME.Resources.Resource", typeof(Form1).Assembly);
                string message1 = rm.GetString("cogratulation, You are winner!!!", culture);
                string message2 = rm.GetString("sorry, You failed.", culture);

                timer2.Stop();
                if (BoardGame.checkGameCompleted())
                    MessageBox.Show(message1);
                else
                    MessageBox.Show(message2);
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
            ResourceManager rm = new ResourceManager("LTTQ_SUDOKU_GAME.Resources.Resource", typeof(Form1).Assembly);
            string message = rm.GetString("sudoku Game version 1.0", culture);

            MessageBox.Show(message);
        }
        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager("LTTQ_SUDOKU_GAME.Resources.Resource", typeof(Form1).Assembly);
            string message = rm.GetString("complete the Sudoku puzzle so that each and every row, column, and region contains the numbers one through nine only once", culture);
            MessageBox.Show(message);
        }
        #endregion

        #region MenuStrip-Language
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetLanguage("en-US");
        }

        private void vietnameseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetLanguage("vi-VN");
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("LTTQ_SUDOKU_GAME.Resources.Resource", typeof(Form1).Assembly);

            //MenuToolStrip
            menuToolStripMenuItem.Text = rm.GetString("menu", culture);
            newGameToolStripMenuItem.Text = rm.GetString("new game", culture);
            undoToolStripMenuItem.Text = rm.GetString("undo", culture);
            exitToolStripMenuItem.Text = rm.GetString("exit", culture);

            //LanguageToolStrip
            languageToolStripMenuItem.Text = rm.GetString("language", culture);
            englishToolStripMenuItem.Text = rm.GetString("english", culture);
            vietnameseToolStripMenuItem.Text = rm.GetString("vietnamese", culture);

            //ModeToolStrip
            ModetoolStripMenuItem.Text = rm.GetString("mode", culture);
            ClassicToolStripMenuItem.Text = rm.GetString("classic", culture);
            timeAttackToolStripMenuItem.Text = rm.GetString("time attack", culture);
            easyToolStripMenuItem1.Text = rm.GetString("easy", culture);
            easyToolStripMenuItem.Text = rm.GetString("easy", culture);
            mediumToolStripMenuItem.Text = rm.GetString("medium", culture);
            mediumToolStripMenuItem1.Text = rm.GetString("medium", culture);
            hardToolStripMenuItem.Text = rm.GetString("hard", culture);
            hardToolStripMenuItem1.Text = rm.GetString("hard", culture);

            //HelpToolStrip
            aboutUsToolStripMenuItem.Text = rm.GetString("about us", culture);
            howToPlayToolStripMenuItem.Text = rm.GetString("how to play", culture);
            helpToolStripMenuItem.Text = rm.GetString("help", culture);
            //ToolStrip
            toolStripButton1.Text = rm.GetString("check", culture);
            toolStripButton2.Text = rm.GetString("solve", culture);
            toolStripButton3.Text = rm.GetString("open", culture);
            toolStripButton4.Text = rm.GetString("save", culture);


        }
        #endregion

        #region ToolStrip
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager("LTTQ_SUDOKU_GAME.Resources.Resource", typeof(Form1).Assembly);
            string message1 = rm.GetString("you have entered the wrong answer!", culture);
            string message2 = rm.GetString("game completed! Do you want to start a new game?", culture);
            string message3 = rm.GetString("notification", culture);

            //Kiểm tra xem giá trị nhập vào có đúng không
            if (BoardGame.checkInput() == false)
                MessageBox.Show(message1);
            //Kiểm tra xem người chơi đã chiến thắng chưa
            if (BoardGame.checkGameCompleted())
            {
                //Thay hình ảnh khi thắng
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                DialogResult result = MessageBox.Show(message2, message3, MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    //Tạo game mới và reset đồng hồ
                    if(mode == 1)
                    {
                        NewGameNormal();
                    }
                    else if(mode == 2)
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
