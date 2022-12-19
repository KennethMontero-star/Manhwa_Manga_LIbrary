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
    public partial class ManhwaRecommendations : Form
    {
        public ManhwaRecommendations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainscreen f1 = new mainscreen();
            f1.Show();
        }

        private void btnWindbreaker_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
            userControl11.BringToFront();
        }

        private void btnNoblese_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Show();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
            userControl21.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
            userControl31.BringToFront();
        }

        private void btnsololeveling_Click(object sender, EventArgs e)
        {

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Show();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
            userControl41.BringToFront();
        }

        private void btnEleceed_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Show();
            userControl61.Hide();
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
            userControl51.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Show();
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
            userControl61.BringToFront();
        }

        private void btnMartialpeak_Click(object sender, EventArgs e)
        {

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Show();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
            userControl61.BringToFront();
        }

        private void btnApotheosis_Click(object sender, EventArgs e)
        {

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl81.Show();
            userControl91.Hide();
            userControl101.Hide();
            userControl61.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Show();
            userControl101.Hide();
            userControl91.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Show();
            userControl101.BringToFront();
        }

        private void userControl101_Load(object sender, EventArgs e)
        {

        }
    }
}
