using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace higherlower
{
    public partial class Memory : Form
    {
        public static int rows = 4;
        public static int cols = 4;
        public int firstCardX, firstCardY;
        bool firstCardOpened = false;
        Random rand = new Random();
        string[] symbolsArray = { "🕾", "🖑", "🖍", "☺", "☯", "🖳", "🏶", "★" };
        List<string> availableSymbols = new List<string>();
        string[,] whatSymbol = new string[rows, cols];
        Button[,] cardControls = new Button[rows,cols];
        public void AddIcons(int x, int y)
        {
            int randSymbol = rand.Next(0, availableSymbols.Count);
            whatSymbol[x, y] = availableSymbols[randSymbol];
            availableSymbols.RemoveAt(randSymbol);
        }
        public void OpenCard(int x, int y)
        {
            cardControls[x, y].Text = whatSymbol[x, y];
            cardControls[x, y].BackColor = Color.White;
        }
        public void CloseCard(int x, int y)
        {
            cardControls[x, y].Text = "";
            cardControls[x, y].BackColor = Color.Red;
        }

        public Memory()
        {
            InitializeComponent();
            for (int i = 0; i < symbolsArray.Length * 2; i++)
            {
                int num = i < symbolsArray.Length ? i : i - symbolsArray.Length;
                availableSymbols.Insert(i, symbolsArray[num]);
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Button card = new Button()
                    {
                        Size = new Size(75, 75),
                        Location = new Point(i * 80, j * 80),
                        Visible = true,
                        BackColor = Color.Red,
                        Font = new Font("Arial", 20),
                    };
                    cardControls[i, j] = card;
                    this.Controls.Add(cardControls[i, j]);
                    AddIcons(i, j);
                    int ii = i;
                    int jj = j;
                    card.Click += (sender, args) =>
                    {
                        OpenCard(ii, jj);

                        if (firstCardOpened == false)
                        {
                            firstCardX = ii;
                            firstCardY = jj;
                            firstCardOpened = true;
                        }
                        else
                        {
                            if (whatSymbol[ii, jj] == whatSymbol[firstCardX,firstCardY])
                            {
                                Task.Delay(500).Wait();
                                cardControls[ii, jj].Visible = false;
                                cardControls[firstCardX, firstCardY].Visible = false;

                            }
                            else
                            {
                                Task.Delay(500).Wait();
                                CloseCard(ii, jj);
                                CloseCard(firstCardX, firstCardY);
                                firstCardOpened = false;
                            }
                        }
                    };

                }
            }
        }
    }
}
