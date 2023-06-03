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
        SqlCommand mmd = new SqlCommand();
        List<String> list = new List<string>();
     
        
     

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
            ekle frm_ek = new ekle();
            frm_ek.bunifuekle2.ButtonText = "ekleme";
            frm_ek.state = 0;
            bunifuTransition1.ShowSync(frm_ek);
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
          

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            bag.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okyanus\Desktop\donem-projesi-AHMET-ALASSAF\Magaz\DBMAGAZA.mdf;Integrated Security=True");
            var sql = "SELECT  id ,baslık,yapan,fiyat,cesitler FROM urunliste";
            db = new SqlDataAdapter(sql, bag);
            db.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "sıra";
            dataGridView1.Columns[1].HeaderText = "başlık";
            dataGridView1.Columns[2].HeaderText = "yapan";
            dataGridView1.Columns[3].HeaderText = "fiyat";
            dataGridView1.Columns[4].HeaderText = "çeşitler";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void bunifuBilgi_Click(object sender, EventArgs e)
        {
            Form diab = new home_effect();
            diab.Show();
        }

        private void bunifuduzen_Click(object sender, EventArgs e)
        {
            ekle frm_ek = new ekle();
            frm_ek.bunifuekle2.ButtonText = "duzemleme";
            frm_ek.state =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
            bunifuTransition1.ShowSync(frm_ek);
            try
            {
                bag.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okyanus\Desktop\donem-projesi-AHMET-ALASSAF\Magaz\DBMAGAZA.mdf;Integrated Security=True");
                mmd.Connection = bag;
                bag.Open();
                mmd.CommandText = "SELECT baslık,yapan,fiyat,cesitler,Tarih,Oran FROM urunliste WHERE ID=@ID";
                mmd.Parameters.AddWithValue("@ID",Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value));
                var rd = mmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(Convert.ToString(rd[0]));
                    list.Add(Convert.ToString(rd[1]));
                    list.Add(Convert.ToString(rd[2]));
                    list.Add(Convert.ToString(rd[3]));
                    list.Add(Convert.ToString(rd[4]));
                    list.Add(Convert.ToString(rd[5]));

                }
                
                frm_ek.txtbas.Text = list[0];
                frm_ek.txtyap.Text = list[1];
                frm_ek.txtfiyat.Text = list[2];
                frm_ek.comboBox1.Text = list[3];
                frm_ek.Datepicker1.Value =Convert.ToDateTime(list[4]) ;
                frm_ek.Rating1.Text = list[5];
                bag.Close();

                //image Reading in database
                bag.Open();
                mmd.CommandText = "SELECT FOTOGRAF FROM URUNLISTE WHERE ID=@IDIMAGE";
                mmd.Parameters.AddWithValue("@IDIMAGE", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                byte[] img = (byte[])mmd.ExecuteScalar();
                MemoryStream me = new MemoryStream();
                me.Write(img, 0, img.Length);
                frm_ek.pictureBox1.Image = Image.FromStream(me);

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                bag.Close();
            }
            mmd.Parameters.Clear();
        }

        private void bunifuselme_Click(object sender, EventArgs e)
        {
            bag.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okyanus\Desktop\donem-projesi-AHMET-ALASSAF\Magaz\DBMAGAZA.mdf;Integrated Security=True");
            mmd.Connection = bag;
            bag.Open();
            mmd.CommandText = "DELETE FROM URUNLISTE WHERE ID=@ID";
            mmd.Parameters.AddWithValue("@ID",dataGridView1.CurrentRow.Cells[0].Value);
            mmd.ExecuteNonQuery();
            bag.Close();

            two_effect fr3 = new two_effect();
            fr3.Show();
            mmd.Parameters.Clear();
        }
    }
}
