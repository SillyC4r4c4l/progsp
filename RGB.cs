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
    public partial class RGB : Form
    {
        public static int rows = 6;
        public int score;
        public bool[] isSame = new bool[rows];
        Button[] tileControls = new Button[rows];
        Button[] modelTiles = new Button[rows];
        Dictionary<int,string> correspondsTo = new Dictionary<int,string>();
        Random rand = new Random();
        public void MyIndexes(string text, string str)
        {
            IList<int> myIndexes = new List<int>();
            int index = text.IndexOf(str, StringComparison.OrdinalIgnoreCase);
            while (index != -1)
            {
                myIndexes.Add(index + 1);
                index = text.IndexOf(str, index +1, StringComparison.OrdinalIgnoreCase);
            }
            for (int i = 0; i < myIndexes.Count; i++)
            {
                Debug.WriteLine(myIndexes[i]);
                try
                {
                    if (myIndexes[i] != 0)
                    {
                        correspondsTo.Add(myIndexes[i], str);
                    }
                }
                catch (IndexOutOfRangeException) { }

            }
        }
        public void GenerateModel()
        {
            for (int i = 0;i < rows; i++)
            {
                int myRandInt = rand.Next(0, 3);
                switch (myRandInt)
                {
                    case 0:
                        modelTiles[i].BackColor = Color.Red;
                        break;
                    case 1:
                        modelTiles[i].BackColor = Color.Green;
                        break;
                    case 2:
                        modelTiles[i].BackColor = Color.Blue;
                        break;

                }
            }
        }

        public RGB()
        {
            InitializeComponent();
            for (int i = 0; i < rows; i++)
            {
                Button btn = new Button()
                {
                    Size = new Size(50, 50),
                    Location = new Point(i * 50, 150),
                    Visible = true,
                    BackColor = Color.Black,
                };
                Button modelBtn = new Button()
                {
                    Size = new Size(25, 25),
                    Location = new Point(i * 25, 70),
                    Visible = true,
                };
                tileControls[i] = btn;
                this.Controls.Add(tileControls[i]);
                modelTiles[i] = modelBtn;
                modelTiles[i].BringToFront();
                this.Controls.Add(modelTiles[i]);
            }
            GenerateModel();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            correspondsTo.Clear();
            List<int> sortedIndices = new List<int>();
            List<string> colorsList = new List<string>();
            string myStr = tbx.Text;
            MyIndexes(myStr, "red");
            MyIndexes(myStr, "green");
            MyIndexes(myStr, "blue");
            foreach (KeyValuePair<int, string> kvp in correspondsTo)
            {
                sortedIndices.Add(kvp.Key);
                sortedIndices.Sort();
            }
            foreach (int index in sortedIndices)
            {
                colorsList.Add(correspondsTo[index]);
            }
            for (int i = 0; i < colorsList.Count; i++)
            {
                try
                {
                    switch (colorsList[i])
                    {
                        case "red":
                            tileControls[i].BackColor = Color.Red;
                            break;
                        case "green":
                            tileControls[i].BackColor = Color.Green;
                            break;
                        case "blue":
                            tileControls[i].BackColor = Color.Blue;
                            break;

                    }
                }
                catch (IndexOutOfRangeException) { }

            }
            for (int i = 0; i < rows; i++)
            {
                if (tileControls[i].BackColor == modelTiles[i].BackColor)
                {
                    isSame[i] = true;
                }
                else
                {
                    isSame[i] = false;
                }
                if (!isSame.Contains(false)){
                    score++;
                    label2.Text = score.ToString();
                    GenerateModel();
                }

            }
        }

    }
}


