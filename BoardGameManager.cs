using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace SudokuG
{
    class BoardGameManager
    {
        public Button[][] b;
        public int sz = 40;
        public int n = 9;
        public GroupBox box;
        public int numofEmpty = 50;
        public int currentX = -1;

        public int currentY = -1;

        public BoardGameManager(GroupBox box1)
        {
            this.box = box1;
        }

        #region SolveSudoku
        public int feasible(int[][] grid, int x, int y, int k)
        {
            for (int i = 0; i < 9; i++)
            {
                if (grid[x][i] == k) return 0;
            }
            for (int j = 0; j < 9; j++)
            {
                if (grid[j][y] == k) return 0;
            }
            int a = x / 3;
            int b = y / 3;
            for (int i = 3 * a; i < 3 * a + 3; i++)
            {
                for (int j = 3 * b; j < 3 * b + 3; j++)
                {
                    if (grid[i][j] == k) return 0;
                }
            }
            return 1;
        }
        public void SolveSudoku(int[][] grid, int x, int y)
        {
            if (y == 9)
            {
                if (x == 8)
                {
                    DisplayBoard(grid);
                    return;
                }
                else
                {
                    SolveSudoku(grid, x + 1, 0);
                }
            }
            else if (grid[x][y] == 0)
            {
                for (int k = 0; k <= 9; k++)
                {
                    if (feasible(grid, x, y, k) == 1)
                    {
                        grid[x][y] = k;
                        SolveSudoku(grid, x, y + 1);
                        grid[x][y] = 0;
                    }
                }
            }
            else

            {
                SolveSudoku(grid, x, y + 1);
            }
        }
        public void DisplayBoard(int[][] grid)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    b[i][j].Text = grid[i][j].ToString();
                }
            }
        }
        public void Solve()
        {
            int[][] temp = new int[9][];
            for (int i = 0; i < 9; i++)
            {
                temp[i] = new int[9];
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (b[i][j].Text != " ")
                        temp[i][j] = Convert.ToInt32(b[i][j].Text);
                    else
                        temp[i][j] = 0;
                }
            }
            SolveSudoku(temp, 0, 0);
        }
        #endregion

        #region CreateNewBoard
        public void createBoard()
        {
            b = new Button[n][];
            for (int i = 0; i < n; i++)
            {
                b[i] = new Button[n];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i][j] = new Button();
                    b[i][j].Size = new Size(sz, sz);
                    if (i < 3 && j < 3)
                    {
                        b[i][j].BackColor = Color.FromName("Cornsilk");
                    }
                    else if (i >= 3 && i < 6 && j >= 3 && j < 6)
                    {
                        b[i][j].BackColor = Color.FromName("Cornsilk");
                    }
                    else if (i >= 6 && i < 9 && j >= 6 && j < 9)
                    {
                        b[i][j].BackColor = Color.FromName("Cornsilk");
                    }
                    else if (i >= 6 && i < 9 && j < 3)
                    {
                        b[i][j].BackColor = Color.FromName("Cornsilk");
                    }
                    else if (i >= 6 && i < 9 && j >= 6)
                    {
                        b[i][j].BackColor = Color.FromName("Cornsilk");
                    }
                    else if (i < 3 && j >= 6 && j < 9)
                    {
                        b[i][j].BackColor = Color.FromName("Cornsilk");
                    }
                    else
                    {
                        b[i][j].BackColor = Color.FromName("Khaki");
                    }
                    b[i][j].Text = " ";
                    b[i][j].ForeColor = Color.FromName("Black");
                    b[i][j].Location = new Point(i * sz + sz, j * sz + sz);
                    b[i][j].Click += new EventHandler(button_Click);
                    //b[i][j].Font = new Font(b[i][j].Font, FontStyle.Bold);
                    b[i][j].Font = new Font("Microsoft Sans Serif", 12);
                    box.Controls.Add(b[i][j]);
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            int x = int.Parse(bt.Location.X.ToString());
            x = x / sz - 1;
            int y = int.Parse(bt.Location.Y.ToString());
            y = y / sz - 1;
            currentX = x;
            currentY = y;
        }
        #endregion

        #region CreateNewSudoku
        public static void Init(ref int[][] grid)
        { 
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    grid[i][j] = (i * 3 + i / 3 + j) % 9 + 1;
                }
            }
        }
        public static void ChangeTwoCell(ref int[][] grid, int findValue1, int findValue2)
        {
            int xFaram1, yFaram1, xFaram2, yFaram2;
            xFaram1 = yFaram1 = xFaram2 = yFaram2 = 0;
            for (int i = 0; i < 9; i = i + 3)
            {
                for (int k = 0; k < 9; k = k + 3)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int z = 0; z < 3; z++)
                        {
                            if (grid[i + j][k + z] == findValue1)
                            {
                                xFaram1 = i + j;
                                yFaram1 = k + z;
                            }
                            if (grid[i + j][k + z] == findValue2)
                            {
                                xFaram2 = i + j;
                                yFaram2 = k + z;
                            }
                        }
                    }
                    grid[xFaram1][yFaram1] = findValue2;
                    grid[xFaram2][yFaram2] = findValue1;
                }
            }
        }
        public static void Update(ref int[][] grid, int shuffleLevel)
        {
            for (int repeat = 0; repeat < shuffleLevel; repeat++)
            {
                Random rand = new Random(Guid.NewGuid().GetHashCode());
                Random rand2 = new Random(Guid.NewGuid().GetHashCode());
                ChangeTwoCell(ref grid, rand.Next(1, 10), rand2.Next(1, 10));
            }
        }
        public void CreateSudoku(int numOfEmpty)
        {
            int[][] a = new int[9][];
            for (int i = 0; i < 9; i++)
            {
                a[i] = new int[9];
            }
            Init(ref a);
            Update(ref a, 10);
            Random ran1 = new Random();
            for (int i = 0; i < numofEmpty; i++)
            {
                int i1 = ran1.Next(0, 9);
                int i2 = ran1.Next(0, 9);
                a[i1][i2] = 0 ;
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (a[i][j] == 0)
                        b[i][j].Text = " ";
                    else
                    {
                        b[i][j].Text = a[i][j].ToString();
                        b[i][j].ForeColor = Color.FromName("Red");
                    }
                }
            }
        }

        #endregion

        #region ClearSudoku
        public void ClearSudoku()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    b[i][j].Text = " ";
                    b[i][j].ForeColor = Color.FromName("Black");
                } 
            }
        }
        #endregion

        #region Import-Export
        public void ImportData()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "txt file | *.txt*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                ClearSudoku();
                string filename = op.FileName;
                string[] lines = File.ReadAllLines(filename);
                int[][] a = new int[9][];
                for (int i = 0; i < 9; i++)
                {
                    a[i] = new int[9];
                }
                for (int i = 0; i < 9; i++)
                {
                    int j = 0;
                    foreach (var con in lines[i].Split(' '))
                    {
                        a[i][j] = int.Parse(con);
                        j++;
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (a[i][j] != 0)
                        {
                            b[i][j].Text = a[i][j].ToString();
                            b[i][j].ForeColor = Color.FromName("red");
                        }
                    }
                }
            }
        }
        public void Export()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                string[] contents = new string[9];
                for (int j = 0; j < 9; j++)
                {
                    contents[j] = "";
                    for (int i = 0; i < 9; i++)
                    {
                        string anum = "";
                        if (b[i][j].Text == " ")
                        {
                            anum = "0";
                        }
                        else
                        {
                            anum = b[i][j].Text;
                        }
                        if (i < 8)
                        {
                            contents[j] += anum + " ";
                        }
                        else
                        {
                            contents[j] += anum;
                        }
                    }
                }
                File.WriteAllLines(filename, contents);
            }
        }
        #endregion

        #region CheckInput
        public Boolean checkInput() //check đề nhập vào có trùng cột, hàng, trong ô hay không.
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (b[i][j].Text != " ")
                    {
                        for (int k = i + 1; k < 9; ++k)  // kiem tra theo hang
                        {
                            if (b[k][j].Text != " ")
                            {
                                if (int.Parse(b[i][j].Text) == int.Parse(b[k][j].Text))
                                    return false;
                            }
                        }
                        for (int k = 0; k < i; ++k)  // kiem tra theo hang
                        {
                            if (b[k][j].Text != " ")
                            {
                                if (int.Parse(b[i][j].Text) == int.Parse(b[k][j].Text))
                                    return false;
                            }
                        }
                        for (int k = j + 1; k < 9; ++k)  // kiem tra theo hang
                        {
                            if (b[i][k].Text != " ")
                            {
                                if (int.Parse(b[i][j].Text) == int.Parse(b[i][k].Text))
                                    return false;
                            }
                        }
                        for (int k = 0; k < j; ++k)  // kiem tra theo hang
                        {
                            if (b[i][k].Text != " ")
                            {
                                if (int.Parse(b[i][j].Text) == int.Parse(b[i][k].Text))
                                    return false;
                            }
                        }
                        int boxRowOffset = (i / 3) * 3;
                        int boxColOffset = (j / 3) * 3;

                        for (int k = 0; k < 3; ++k) //kiem tra trong 9 ô nhỏ
                            for (int m = 0; m < 3; ++m)
                                if ((boxRowOffset + k) != i && boxColOffset + m != j)
                                {
                                    if (b[boxRowOffset + k][boxColOffset + m].Text != " ")
                                    {
                                        if (int.Parse(b[i][j].Text) == int.Parse(b[boxRowOffset + k][boxColOffset + m].Text))
                                            return false;
                                    }
                                }
                    }
                }
            }
            return true;
        }
        #endregion

        #region CheckGameCompleted
        //Kiểm tra xem đã điền hết các ô chưa
        public Boolean checkGameCompleted()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (b[i][j].Text == " ")// Còn ô trống 
                        return false;
                }
            }
            return true;
        }
        #endregion
    }
}
