using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Diagnostics;
 


namespace Manhwa_Manga_LIbrary
{
    public partial class mainscreen : Form
    {
        public mainscreen()
        {
            InitializeComponent();
            string mysqlcon = "server = localhost;user id root; password=;database=mangaxmanhwarecord";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);

            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Succesfull");
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            
            }
            finally { mySqlConnection.Close(); }    

        } 
        string[] picture = Directory.GetFiles("C:\\ManhwaImages");

        int pictureindex = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureindex > 0)
                pictureindex -= 1;
            pictureBox1.Image = Image.FromFile(picture[pictureindex]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureindex < picture.Length - 1)
                pictureindex += 1;
            pictureBox1.Image = Image.FromFile(picture[pictureindex]);
        }
        string[] picture1 = Directory.GetFiles("C:\\MangaImages");

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureindex > 0)
                pictureindex -= 1;
            pictureBox2.Image = Image.FromFile(picture1[pictureindex]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureindex < picture1.Length - 1)
                pictureindex += 1;
            pictureBox2.Image = Image.FromFile(picture1[pictureindex]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManhwaRecommendations f2 = new ManhwaRecommendations();
            f2.Show();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MangaRecommendations f3 = new MangaRecommendations();
            f3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_Setting f4 = new Search_Setting();
            f4.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string connection = "server = localhost;user id root; password=;database=mangaxmanhwarecord";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("SELECT * FROM tbl_record WHERE TITLE LIKE '" + this.textBox1.Text + "%' OR STATUS LIKE '" + this.textBox1.Text +"%'", conn);
            dt = new DataTable();
            da.Fill(dt);  
            dt.Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

            foreach (DataRow row in dt.Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Image\" + Path.GetFileName(row["IMAGE"].ToString()));
            }
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void mainscreen_Load(object sender, EventArgs e)
        {
            string connection = "server = localhost;user id root; password=;database=mangaxmanhwarecord";
            string query = "SELECT * FROM tbl_record";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

            foreach (DataRow row in dt.Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Image\" + Path.GetFileName(row["IMAGE"].ToString()));
            }
            dataGridView1.DataSource = dt;


           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==6)

                if (e.ColumnIndex ==6)
                 
                Process.Start("https://chapmanganato.com/");
              
               
           
        }
        private void btn_click(object sender, EventArgs e)
        {
            
            DataGridViewLinkColumn LINKS = new DataGridViewLinkColumn();
            dataGridView1.Columns.Add(LINKS);
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
    }

}
