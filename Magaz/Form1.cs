using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Magaz
{
    public partial class Form1 : Form
    {
        //var for moved

        int move;
        int movx;
        int movy;

        //var for sqlcon
        SqlConnection bag = new SqlConnection();
        SqlDataAdapter db = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuekle_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - move, MousePosition.Y - move);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            bag.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okyanus\Desktop\donem-projesi-AHMET-ALASSAF\Magaz\DBMAGAZA.mdf;Integrated Security=True");
            var sql = "SELECT  id as sıralam,başlık,yapan,fiyat,çeşitler FROM urunliste";
            db = new SqlDataAdapter(sql, bag);
            db.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
