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

namespace PROGRAMMING_PROJECT
{
    public partial class UserControl13 : UserControl
    {
        public UserControl13()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.mangabed.com/manga/slam-dunk/chapter2_8zvq8");
        }
    }
}
