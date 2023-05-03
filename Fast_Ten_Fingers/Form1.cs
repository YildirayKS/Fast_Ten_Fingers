using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Fast_Ten_Fingers
{
    public partial class Form1 : Form
    {
        int time = 60;
        int point = 0;
        int trueCount, falseCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtbox_words.Text.ToLower() == lbl_word.Text)
                {
                    trueCount++;
                    point++;
                    lbl_point.Text = "Point: " + point;
                    txtbox_words.Clear();
                    randomWord();
                }
                else
                {
                    falseCount++;
                    txtbox_words.Clear();
                    randomWord();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                lbl_time.Text = "Time: " + time;
            }
            else
            {
                timer1.Enabled = false;
                btn_start.Visible = true;
                hideAll();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            randomWord();

            point = 0;
            trueCount = 0;
            falseCount = 0;

            lbl_point.Text = "Point: " + point;
            lbl_time.Text = "Time: 60";

            lbl_time.Visible = true;
            lbl_point.Visible = true;
            lbl_word.Visible = true;

            lbl_yourpoint.Visible = false;
            lbl_true.Visible = false;
            lbl_false.Visible = false;

            txtbox_words.Visible = true;

            btn_start.Visible = false;
        }

        public void hideAll()
        {
            time = 60;
            lbl_time.Visible = false;
            lbl_point.Visible = false;
            lbl_word.Visible = false;

            lbl_yourpoint.Visible = true;
            lbl_true.Visible = true;
            lbl_false.Visible = true;

            txtbox_words.Visible = false;

            lbl_yourpoint.Text = "Your Point: " + point;
            lbl_true.Text = "True: " + trueCount;
            lbl_false.Text = "False: " + falseCount;
        }

        public void randomWord()
        {
            Random randomWord = new Random();

            string filePath = @"C:Words.txt";

            string[] words = File.ReadAllLines(filePath);

            Random random = new Random();
            string word = words[random.Next(words.Length)];

            lbl_word.Text = word;
        }
    }
}
