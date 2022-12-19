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
    public partial class UserControl10 : UserControl
    {
        public UserControl10()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.mangaread.org/manga/the-beginning-after-the-end/chapter-1-the-end-of-the-tunnel/");
        }
    }
}
