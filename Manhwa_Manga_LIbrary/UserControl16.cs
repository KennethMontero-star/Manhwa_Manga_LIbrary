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
    public partial class UserControl16 : UserControl
    {
        public UserControl16()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.myhero-academia.com/comic/my-hero-academia-chapter-1/");
        }
    }
}
