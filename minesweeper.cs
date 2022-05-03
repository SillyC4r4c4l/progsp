using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace higherlower
{
    public partial class Minesweeper : Form
    {
        static int rows = 15;
        static int cols = 15;
        static bool[,] isBomb = new bool[rows, cols];
        static bool[,] firstClickExplosion = new bool[rows, cols];
        static bool[,] clickedBefore = new bool[rows, cols];
        public int[] myRandoms = new int[4];
        public bool addingFlag = false;
        Button[,] btnControls = new Button[rows, cols];
        private void Clicked(int x, int y)
        {
            int adj = 0;
            for (int n1 = -1; n1 <= 1; n1++)
            {
                for (int n2 = -1; n2 <= 1; n2++)
                {
                    try
                    {
                       if (isBomb[x + n2, y + n1])
                       {
 
                            
                                adj++;
                            
                       }   
                    }
                    catch (IndexOutOfRangeException) { }
                }
            }
            btnControls[x, y].BackColor = Color.LightGreen;
            btnControls[x, y].Text = adj.ToString();
            clickedBefore[x, y] = true;

        }
        public Minesweeper()
        {
            InitializeComponent();
            Random rand = new Random();
            bool firstClickMade = false;
            for (int x = 0; x < 20; x++)
            {
                isBomb[rand.Next(0, rows), rand.Next(0, cols)] = true;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Button btn = new Button()
                    {
                        Size = new Size(25, 25),
                        Location = new Point(i * 20,j *20),
                        Visible = true,
                    };

                    if (isBomb[i,j] == true)
                    {
                        btn.BackColor = Color.LightPink;
                    }
                    btnControls[i, j] = btn;
                    this.Controls.Add(btnControls[i, j]);
                    int ii = i;
                    int jj = j;
                    btn.Click += (sender, args) =>
                    {
                        if (addingFlag == true)
                        {
                            if (btnControls[ii, jj].Text == "⚑")
                            {
                                if (clickedBefore[ii, jj] == true)
                                {
                                    Clicked(ii, jj);
                                }
                                else
                                {
                                    btnControls[ii, jj].Text = "";
                                }
                            }
                            else
                            {
                                btnControls[ii, jj].Text = "⚑";
                            }
                            addingFlag = false;
                            btnAddFlag.BackColor = Color.Gray;

                        }
                        else
                        {
                            if (firstClickMade == false)
                            {

                                for (int x = rand.Next(-2, 1); x <= rand.Next(0, 3); x++)                    //WITH RANDOMS
                                {
                                    for (int y = rand.Next(-2, 1); y <= rand.Next(0, 3); y++)
                                    {
                                        try
                                        {
                                            isBomb[ii + y, jj + x] = false;
                                            firstClickExplosion[ii + y, jj + x] = true;

                                        }
                                        catch (IndexOutOfRangeException) { }

                                    }
                                }
                                for (int a = 0; a < rows; a++)
                                {
                                    for (int b = 0; b < rows; b++)
                                    {
                                        if (firstClickExplosion[a, b] == true)
                                        {
                                            Clicked(a, b);
                                        }
                                    }

                                }
                                /*
                                for (int x = -1; x <= 1; x++)                       NORMAL GRID
                                {
                                    for (int y = -1; y <= 1; y++)
                                    {
                                        try
                                        {
                                            isBomb[ii + y, jj + x] = false;
                                            Clicked(ii + y, jj + x);
                                        }
                                        catch (IndexOutOfRangeException) { }

                                    }
                                }
                                */
                                firstClickMade = true;
                            }

                            if (isBomb[ii, jj] == true)
                            {
                                MessageBox.Show("kaboom");
                            }
                            else
                            {
                                /*for (int x = -1; x <= 1; x++)
                                {
                                    for (int y = -1; y <= 1; y++)
                                    {
                                        try
                                        {
                                            if (isBomb[ii + y, jj + x])
                                            {
                                                adjBombs++;
                                            }
                                        }
                                        catch (IndexOutOfRangeException) { }
                                    }
                                }
                                //btn.Text = adjBombs.ToString();
                                */
                                Clicked(ii, jj);
                            }
                        }
                    };
                } 
            }
        }

        private void btnAddFlag_Click(object sender, EventArgs e)
        {
            addingFlag = true;
            btnAddFlag.BackColor = Color.Orange;
        }
    }
}
