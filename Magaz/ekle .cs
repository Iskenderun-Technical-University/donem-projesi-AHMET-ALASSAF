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
    public partial class ekle : Form
    {
        //for  sql

        SqlConnection bag = new SqlConnection();
        SqlCommand mmd = new SqlCommand();
        List<String> list = new List<string>();

        public int state;
        public ekle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butek1_Click(object sender, EventArgs e)
        {
            Form frm_cesit = new cesitler();
            bunifuTransition1.ShowSync(frm_cesit);
        }

        private void ekle_Load(object sender, EventArgs e)
        {
            try
            {
                bag.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okyanus\Desktop\donem-projesi-AHMET-ALASSAF\Magaz\DBMAGAZA.mdf;Integrated Security=True");
                mmd.Connection = bag;
                bag.Open();
                mmd.CommandText = "SELECT Cesit FROM CLAS";
                var rd = mmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(Convert.ToString(rd[0]));
                }
                int i = 0;
                while (i<list.LongCount())
                {
                    comboBox1.Items.Add(list[i]);
                    i = i + 1;
                }
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                bag.Close();
            }
        }

        private void bunifuekle2_Click(object sender, EventArgs e)
        {
            if (txtyap.Text=="" || txtbas.Text=="")
            {
                MessageBox.Show("Önce ürün bilgilerini doldurunuz");
            }
            else
            {
                if (state == 0)
                {
                    //INSERT

                    //for convert image to bainry

                    MemoryStream ma = new MemoryStream();
                    pictureBox1.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _pictureBox = ma.ToArray();

                    //sql command 

                    bag.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okyanus\Desktop\donem-projesi-AHMET-ALASSAF\Magaz\DBMAGAZA.mdf;Integrated Security=True");
                    bag.Open();
                    mmd.Connection = bag;
                    mmd.CommandText = "INSERT INTO urunliste (baslık,yapan,fiyat,cesitler,Tarih,Oran,fotograf) VALUES (@baslık,@yapan,@fiyat,@cesitler,@Tarih,@Oran,@fotograf)";
                    mmd.Parameters.AddWithValue("@baslık", txtbas.Text);
                    mmd.Parameters.AddWithValue("@yapan", txtyap.Text);
                    mmd.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
                    mmd.Parameters.AddWithValue("@cesitler", comboBox1.Text);
                    mmd.Parameters.AddWithValue("@Tarih", Datepicker1.Value);
                    mmd.Parameters.AddWithValue("@Oran", Rating1.Value);
                    mmd.Parameters.AddWithValue("@fotograf", _pictureBox);
                    mmd.ExecuteNonQuery();
                    bag.Close();
                    Form fr1 = new home_effect();
                    fr1.Show();
                    this.Close();
                }
                else
                {
                    //DUZENLEME


                    //for convert image to bainry

                    MemoryStream ma = new MemoryStream();
                    pictureBox1.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _pictureBox = ma.ToArray();

                    //sql command 

                    bag.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okyanus\Desktop\donem-projesi-AHMET-ALASSAF\Magaz\DBMAGAZA.mdf;Integrated Security=True");
                    bag.Open();
                    mmd.Connection = bag;
                    mmd.CommandText = "UPDATE urunliste SET baslık=@baslık,yapan=@yapan,fiyat=@fiyat,cesitler=@cesitler,Tarih=@Tarih,Oran=@Oran,fotograf=@fotograf WHERE ID=@ID";
                    mmd.Parameters.AddWithValue("@baslık", txtbas.Text);
                    mmd.Parameters.AddWithValue("@yapan", txtyap.Text);
                    mmd.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
                    mmd.Parameters.AddWithValue("@cesitler", comboBox1.Text);
                    mmd.Parameters.AddWithValue("@Tarih", Datepicker1.Value);
                    mmd.Parameters.AddWithValue("@Oran", Rating1.Value);
                    mmd.Parameters.AddWithValue("@fotograf", _pictureBox);
                    mmd.Parameters.AddWithValue("@ID", state);
                    mmd.ExecuteNonQuery();
                    bag.Close();
                    Form fr2 = new three_effect();
                    fr2.Show();
                    this.Close();
            }
            }

            mmd.Parameters.Clear();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dia = new OpenFileDialog();
            var result = dia.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dia.FileName);
            }
        }
    }
}
