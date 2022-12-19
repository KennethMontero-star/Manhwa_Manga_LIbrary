using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manhwa_Manga_LIbrary
{
    public partial class MangaRecommendations : Form
    {
        public MangaRecommendations()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            userControl111.Hide();
            userControl121.Hide();
            userControl131.Hide();
            userControl141.Hide();
            userControl151.Hide();
            userControl161.Hide();
            userControl171.Show();
            userControl181.Hide();
            userControl191.Hide();
            userControl171.Show();
            userControl171.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl111.Show();
            userControl121.Hide();
            userControl131.Hide();
            userControl121.Hide();
            userControl151.Hide();
            userControl161.Hide();
            userControl171.Hide();
            userControl181.Hide();
            userControl191.Hide();
            userControl111.Show();
            userControl111.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl111.Hide();
            userControl121.Show();
            userControl131.Hide();
            userControl141.Hide();
            userControl151.Hide();
            userControl161.Hide();
            userControl171.Hide();
            userControl181.Hide();
            userControl191.Hide();
            userControl121.Show();
            userControl121.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainscreen f1 = new mainscreen();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl111.Hide();
            userControl121.Hide();
            userControl131.Show();
            userControl141.Hide();
            userControl151.Hide();
            userControl161.Hide();
            userControl171.Hide();
            userControl181.Hide();
            userControl191.Hide();
            userControl131.Show();
            userControl131.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl111.Hide();
            userControl121.Hide();
            userControl131.Hide();
            userControl141.Show();
            userControl151.Hide();
            userControl161.Hide();
            userControl171.Hide();
            userControl181.Hide();
            userControl191.Hide();
            userControl141.Show();
            userControl141.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userControl111.Hide();
            userControl121.Hide();
            userControl131.Hide();
            userControl141.Hide();
            userControl151.Show();
            userControl161.Hide();
            userControl171.Hide();
            userControl181.Hide();
            userControl191.Hide();
            userControl151.Show();
            userControl151.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            userControl111.Hide();
            userControl121.Hide();
            userControl131.Hide();
            userControl141.Hide();
            userControl151.Hide();
            userControl161.Show();
            userControl171.Hide();
            userControl181.Hide();
            userControl191.Hide();
            userControl161.Show();
            userControl161.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            userControl111.Hide();
            userControl121.Hide();
            userControl131.Hide();
            userControl141.Hide();
            userControl151.Hide();
            userControl161.Hide();
            userControl171.Hide();
            userControl181.Hide();
            userControl191.Show();
            userControl161.Hide();
            userControl191.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            userControl111.Hide();
            userControl121.Hide();
            userControl131.Hide();
            userControl141.Hide();
            userControl151.Hide();
            userControl161.Hide();
            userControl171.Hide();
            userControl181.Show();
            userControl191.Hide();
            userControl211.Hide();
            userControl181.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            userControl111.Hide();
            userControl121.Hide();
            userControl131.Hide();
            userControl141.Hide();
            userControl151.Hide();
            userControl161.Hide();
            userControl171.Hide();
            userControl181.Hide();
            userControl191.Hide();
            userControl211.Show();
            userControl211.BringToFront();
        }

        private void userControl211_Load(object sender, EventArgs e)
        {

        }
    }
}
