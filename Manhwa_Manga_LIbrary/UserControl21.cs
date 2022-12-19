using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manhwa_Manga_LIbrary
{
    public partial class UserControl21 : UserControl
    {
        public UserControl21()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ww6.read-onepiecemanga.com/manga/one-piece-chapter-1/?2022-12-09");
        }
    }
}
