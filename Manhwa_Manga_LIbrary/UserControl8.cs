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


namespace PROGRAMMING_PROJECT
{
    public partial class UserControl8 : UserControl
    {
        public UserControl8()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://readapotheosismanga.com/manga/apotheosis-chapter-1/");
        }
    }
}
