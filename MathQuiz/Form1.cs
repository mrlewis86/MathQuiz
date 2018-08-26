using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int addend1;
        int addend2;

        public void StartTheQuiz()
        {

            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            
            sum.Value = 0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Product_ValueChanged(object sender, EventArgs e)
        {

        }

        private void plusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void MinusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void DividendLeftLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
