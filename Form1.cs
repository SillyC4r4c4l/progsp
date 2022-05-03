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
    public partial class Form1 : Form
    {
        Rectangle higherLowGame;
        Rectangle mineSweeperGame;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            higherLowGame = new Rectangle(picHigherLow.Location,picHigherLow.Size);
            mineSweeperGame = new Rectangle(picMineSweeper.Location, picMineSweeper.Size);
            bool ms = true;
            if (ms == true)
            {
                Hangman gaem = new Hangman();
                gaem.ShowDialog();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string vChar = e.KeyChar.ToString();
            switch (vChar)
            {
                case "w":
                    picPlayer.Top = picPlayer.Top - 10;
                    break;
                case "s":
                    picPlayer.Top = picPlayer.Top + 10;
                    break;
                case "a":
                    picPlayer.Left = picPlayer.Left - 10;
                    break;
                case "d":
                    picPlayer.Left = picPlayer.Left + 10;
                    break;

                    
                 
            }
            CheckCollide();
        }
        private void CheckCollide()
        {
           if ( higherLowGame.IntersectsWith(new Rectangle(picPlayer.Location, picPlayer.Size)))
            {
                HigherLow gameHigherLow = new HigherLow();
                gameHigherLow.ShowDialog();
            }
            if (mineSweeperGame.IntersectsWith(new Rectangle(picPlayer.Location, picPlayer.Size)))
            {
                Minesweeper gameMinesweeper = new Minesweeper();
                gameMinesweeper.ShowDialog();
            }
        }
    }
}
