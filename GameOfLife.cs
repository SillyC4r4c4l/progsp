using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace higherlower
{
    public partial class GameOfLife : Form
    {
        public static int rows = 15;
        public static int cols = 15;
        bool[,] isAlive = new bool[rows, cols];
        PictureBox[,] tileControls = new PictureBox[rows, cols];
        private void CellDie( int x, int y)
        {
            isAlive[x, y] = false;
            tileControls[x, y].BackColor =
                y % 2 == 0 ? (x % 2 == 0 ? Color.Gray : Color.DarkGray)
                           : (x % 2 == 0 ? Color.DarkGray : Color.Gray);
        }
        private void CellAlive(int x, int y)
        {
            isAlive[x, y] = true;
            tileControls[x, y].BackColor = Color.Purple;
        }
        private void RunSim()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int liveAdj = 0;
                    for (int x = -1; x <= 1; x++)
                    {
                        for (int y = -1; y <= 1; y++)
                        {
                            try
                            {
                                if (isAlive[i + y, j + x])
                                {
                                    liveAdj++;
                                }
                            }
                            catch (IndexOutOfRangeException) { }
                        }

                    }
                    if (isAlive[i, j] == true)
                    {
                        if (liveAdj < 2 || liveAdj > 3)
                        {
                            CellDie(i, j);
                        }
                    }
                    else
                    {
            
                        if (liveAdj == 3)
                        {
                            CellAlive(i, j);
                        }
                    }
                }
            }
        }
        public GameOfLife()
        {
            InitializeComponent();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    PictureBox tile = new PictureBox()
                    {
                        Size = new Size(25, 25),
                        Location = new Point(i * 25, j * 25),
                        BackColor = j % 2 == 0 ? (i % 2 == 0 ? Color.Gray : Color.DarkGray) : (i % 2 == 0 ? Color.DarkGray : Color.Gray),
                        Visible = true,
                    };
                    tileControls[i, j] = tile;
                    this.Controls.Add(tileControls[i, j]);
                    int ii = i;
                    int jj = j;
                    tile.Click += (sender, args) =>
                    {
                        CellAlive(ii, jj);
                    };

                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            RunSim();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    CellDie(i, j);
               }
            }
        }
    }
}
