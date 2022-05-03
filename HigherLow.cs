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
    public partial class HigherLow : Form
    {
        public HigherLow()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        int newRandom;
        int oldRandom=7;
        int score = 0;

        private void HigherLow_Load(object sender, EventArgs e)
        {
            NewRandomNumber();
        }
        public void NewRandomNumber()
        {
            newRandom = rd.Next(1,10);
            lblRandNumber.Text = newRandom.ToString();
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            oldRandom = newRandom;
            NewRandomNumber();
            if (newRandom < oldRandom)
            {
                score++;
            }
            else
            {
                score = 0;
            }
            lblScore.Text = score.ToString();

        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            oldRandom = newRandom;
            NewRandomNumber();
            if(newRandom > oldRandom)
            {
                score++;
            }
            else
            {
                score = 0;
            }
            lblScore.Text = score.ToString();
        }
    }
}
