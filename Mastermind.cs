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
    public partial class Mastermind : Form
    {
        public static int rows = 4;
        public static int cols = 8;
        Button[,] btnControls = new Button[rows, cols];
        Button[,,] pinControls = new Button[cols,2, 2];
        public Mastermind()
        {
            InitializeComponent();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Button btn = new Button()
                    {
                        Size = new Size(50, 50),
                        Location = new Point(i * 50, j * 50),
                        Visible = true,
                        BackColor = Color.Black,
                    };
                    btnControls[i, j] = btn;
                    this.Controls.Add(btnControls[i, j]);
                    for (int x = 0; x < 2; x++)
                    {
                        for (int y = 0; y < 2; y++)
                        {
                            
                                Button pin = new Button()
                                {
                                    Size = new Size(20, 20),
                                    Location = new Point(300 + x * 20, j  * y * 20),
                                    Visible = true,
                                    BackColor = Color.Black,
                                };
                                pinControls[j,x, y] = pin;
                                this.Controls.Add(pinControls[j,x, y]);
                            
                        }
                    }
                }
            }
        }
    }
}
