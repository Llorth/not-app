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
namespace DersNotKayıt
{
    public partial class FrmOgrDetay : Form
    {
        public FrmOgrDetay()
        {
            InitializeComponent();
        }
        public string numara;
        // git 3
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5QT0LF3\SQLEXPRESS;Initial Catalog=DersNotKayıt;Integrated Security=True");
        private void FrmOgrDetay_Load(object sender, EventArgs e)
        {
             lblnum.Text = numara;
             baglanti.Open();
             SqlCommand komut = new SqlCommand("Select * from TBLOGR where OGRNUMARA=@p1", baglanti);
             komut.Parameters.AddWithValue("@p1", numara);
             SqlDataReader oku = komut.ExecuteReader();
             while (oku.Read())
             {

                 lblnum.Text = oku[1].ToString();
                 lbladsoyad.Text = oku[2].ToString() + " " + oku[3].ToString();
                 lbls1.Text = oku[4].ToString();
                 lbls2.Text = oku[5].ToString();
                 lbls3.Text = oku[6].ToString();
                 lblort.Text = oku[7].ToString();
                lbldurum.Text = oku[8].ToString();
                if (lbldurum.Text== "True")
                {
                    lbldurum.Text = "Geçti";

                }
                else
                if (lbldurum.Text=="False")
                {
                    lbldurum.Text = "Kaldı";
                }

                 

             }
            baglanti.Close();


        }
    }
    
}
