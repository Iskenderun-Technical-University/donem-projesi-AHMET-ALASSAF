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
    public partial class cesitler : Form
    {
        //vars for sql
        SqlConnection bag = new SqlConnection();
        SqlCommand mmd = new SqlCommand();


       

        public cesitler()
        {
            InitializeComponent();
        }

        private void bunifuclose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuekle_Click(object sender, EventArgs e)
        {
            if (TEXTER.Text!= "")
            {
                bag.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\okyanus\Desktop\donem-projesi-AHMET-ALASSAF\Magaz\DBMAGAZA.mdf;Integrated Security=True");
                bag.Open();
                mmd.Connection = bag;
                mmd.CommandText = "INSERT INTO CLAS (Cesit) VALUES (@Cesit)";
                mmd.Parameters.AddWithValue("@Cesit", TEXTER.Text);
                mmd.ExecuteNonQuery();
                bag.Close();
                Form fr1 = new home_effect();
                fr1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("lütfen önce çeşiti adını yazınız ");
            }
           

        }
    }
}
