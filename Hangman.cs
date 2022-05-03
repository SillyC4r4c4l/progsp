using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace higherlower
{

  
    public partial class Hangman : Form
    {
        Random rand = new Random();
        static string path = "dictionary.txt";
        static string[] words = File.ReadAllLines(path, Encoding.UTF8);
        public string myWord;
        public int errors;
        public static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public Button[] tileControls;
        public Button[] alphaControls = new Button[alphabet.Length];
        public bool[] isSame;
        public List<PictureBox> duckParts = new List<PictureBox>();


        public Hangman()
        {
            foreach (PictureBox x in Controls)
            {
                    duckParts.Add(x);
            }
            MessageBox.Show(duckParts.Count().ToString());
            InitializeComponent();
            GenerateWord();
            label1.Text = myWord;
            GenerateAlphaButtons();
        }
        public void GenerateWord()
        {
            myWord = words[rand.Next(0, words.Length)];
            isSame = new bool[myWord.Length];
            tileControls = new Button[myWord.Length];
            for (int i = 0; i < myWord.Length; i++)
            {
                Button btn = new Button()
                {
                    Size = new Size(50, 50),
                    Location = new Point(i * 50, 150),
                    Visible = true,
                    BackColor = Color.LightGray,
                };
                tileControls[i] = btn;
                this.Controls.Add(tileControls[i]);
            }

        }
        public void GenerateAlphaButtons()
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                Button btn = new Button()
                {
                    Size = new Size(25, 25),
                    Location = new Point(i * 25, 300),
                    Visible = true,
                    BackColor = Color.LightGreen,
                    Text = alphabet[i].ToString(),
                };
                alphaControls[i] = btn;
                this.Controls.Add(alphaControls[i]);
                btn.Click += (sender, args) =>
                {
                    for (int j = 0; j < myWord.Length; j++)
                    {
                        if (myWord[j].ToString() == btn.Text)
                        {
                            tileControls[j].Text = btn.Text;
                            isSame[j] = true;
                        }
                        else
                        {
                            if (errors < 4)
                            {
                                errors++;
                                duckParts[1].Visible = true;
                            }
                            else
                            {
                                label1.Text = "game over";
                            }
                        }
                        if (!isSame.Contains(false))
                        {
                            MessageBox.Show("hjdksh");
                        }

                    }
                   
                };

        }

    }

        private void Hangman_Load(object sender, EventArgs e)
        {

        }
    }
}
