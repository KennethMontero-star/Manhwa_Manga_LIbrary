using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;



namespace Manhwa_Manga_LIbrary
{
    public partial class Search_Setting : Form
    {
        public Search_Setting()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainscreen f1 = new mainscreen();
            f1.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connection = "server = localhost;user id root; password=;database=mangaxmanhwarecord";
            string query = "INSERT INTO tbl_record (TITLE,AUTHOR,CHAPTER,STATUS,GENRE,LINK,IMAGE)VALUES('" + this.TitleBox.Text + "','" + this.AuthorBox.Text + "','" + this.ChapterBox.Text + "','" + this.StatusBox.Text + "','" + this.GenreBox.Text + "','" + this.Linktxt.Text + "','" + Path.GetFileName(pictureBox1.ImageLocation) + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully Save");
            conn.Close();
            File.Copy(Imagetxt.Text, Application.StartupPath + @"\Image\" + Path.GetFileName(pictureBox1.ImageLocation));

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string connection = "server = localhost;user id root; password=;database=mangaxmanhwarecord";
            string query = "UPDATE  tbl_record SET TITLE = '" + this.TitleBox.Text + "', AUTHOR = '" + this.AuthorBox.Text + "',CHAPTER = '" + this.ChapterBox.Text+ "', STATUS = '" + this.StatusBox.Text+ "',GENRE ='" + this.GenreBox.Text+"'WHERE NUMBER ='" + this.NumberBox.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Updated Succesfully");
            while (dr.Read()) 
            {
            
            }

            File.Copy(Imagetxt.Text, Application.StartupPath + @"\Image\" + Path.GetFileName(pictureBox1.ImageLocation));
            conn.Close();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            string connection = "server = localhost;user id root; password=;database=mangaxmanhwarecord";
            string query = "SELECT * FROM tbl_record";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand= cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add( "PICTURE", Type.GetType("System.Byte[]"));
            
            foreach (DataRow row in dt.Rows) 
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Image\" + Path.GetFileName(row["IMAGE"].ToString()));
            }
            dataGridView1.DataSource= dt;
           
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            string connection = "server = localhost;user id root; password=;database=mangaxmanhwarecord";
            string query = "DELETE FROM tbl_record WHERE  NUMBER ='" + this.NumberBox.Text+"'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open(); 
            dr = cmd.ExecuteReader();
            MessageBox.Show("DELETED");
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {   
                // manga
                Process.Start("https://chapmanganato.com/");
            }
        }
          

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg;*.jpeg;*.gif) | *.jpg; *. jpeg; * .gif;";
            if(ofd.ShowDialog() == DialogResult.OK) 
            { 
                Imagetxt.Text= ofd.FileName;
                pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox1.ImageLocation = ofd.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg;*.jpeg;*.gif) | *.jpg; *. jpeg; * .gif;";
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void Search_Setting_Load(object sender, EventArgs e)
        {
            
        }

        private void NumberBox_TextChanged(object sender, EventArgs e)
        {

        }



        public void clearInputFields() 
        {
        //clearing textbox
            NumberBox.Text = string.Empty;
            TitleBox.Text = string.Empty;
            AuthorBox.Text = string.Empty;
            ChapterBox.Text = string.Empty;
            StatusBox.Text = string.Empty;
            GenreBox.Text = string.Empty;
            Linktxt.Text = string.Empty;
          
            


        }
        private void button1_Click(object sender, EventArgs e)
        {
            clearInputFields();
        }

        private void Linktxt_TextChanged(object sender, EventArgs e)
        {
            

        }
        private void btn_click (object sender, EventArgs e) 
        {
            DataGridViewLinkColumn LINKS = new DataGridViewLinkColumn();
            LINKS.UseColumnTextForLinkValue = true;
            LINKS.LinkBehavior = LinkBehavior.SystemDefault;
            LINKS.HeaderText = "Link Data";
            LINKS.Name = "Click to read";
            LINKS.LinkColor = Color.Blue;
            LINKS.TrackVisitedState = true;
            LINKS.Text = "https://chapmanganato.com/";
            LINKS.UseColumnTextForLinkValue = true;

            dataGridView1.Columns.Add(LINKS);

        }

        private void Comictypetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatusBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
