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
    public partial class FrmOgretmenDetay : Form
    {


        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5QT0LF3\SQLEXPRESS;Initial Catalog=DersNotKayıt;Integrated Security=True");
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dersNotKayıtDataSet.TBLOGR' table. You can move, or remove it, as needed.
            this.tBLOGRTableAdapter.Fill(this.dersNotKayıtDataSet.TBLOGR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {



                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLOGR (OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", msknumara.Text);
                komut.Parameters.AddWithValue("@p2", txtad.Text);
                komut.Parameters.AddWithValue("@p3", txtsoyad.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tBLOGRTableAdapter.Fill(this.dersNotKayıtDataSet.TBLOGR);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Girilen Değerleri Kontrol Edin");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            msknumara.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            txtad.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            txts1.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            txts2.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            txts3.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();
        }
       
        
        private void btnsınavkydt_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            try
            {

                


                s1 = Convert.ToDouble(txts1.Text);
                s2 = Convert.ToDouble(txts2.Text);

                if (txts3.Text == "" || txts3.Text == null)
                {

                    ortalama = (s1 + s2) / 2;
                }
                else
                {

                    s3 = Convert.ToDouble(txts3.Text);
                    ortalama = (s1 + s2 + s3) / 3;
                }
                if (ortalama >= 70)
                {
                    durum = "True";

                }
                else
                {
                    durum = "False";
                }
                lblortalama.Text = ortalama.ToString("00.00");
                baglanti.Open();
                

                SqlCommand komut = new SqlCommand("Update TBLOGR set OGRAD=@A1, OGRSOYAD=@A2, OGRS1= @s1, OGRS2 = @s2, OGRS3=@s3, ORTALAMA =@O4, DURUM=@D5 where OGRNUMARA=@p1", baglanti);
                komut.Parameters.AddWithValue("@s1", txts1.Text);
                komut.Parameters.AddWithValue("@s2", txts2.Text);
                komut.Parameters.AddWithValue("@s3", txts3.Text ?? null);
                komut.Parameters.AddWithValue("@O4", decimal.Parse(lblortalama.Text));
                komut.Parameters.AddWithValue("@D5", durum);
                komut.Parameters.AddWithValue("@p1", msknumara.Text);
                komut.Parameters.AddWithValue("@A1", txtad.Text);
                komut.Parameters.AddWithValue("@A2", txtsoyad.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tBLOGRTableAdapter.Fill(this.dersNotKayıtDataSet.TBLOGR);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Girilen Değerleri Kontrol Edin");
            }
           

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {

            int gecen = 0, kalan = 0; int i = 0;
            while (dataGridView1.Rows[i].Cells[0].Value != null)

            {

                if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "True")

                    gecen = gecen + 1;

                if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "False")

                    kalan++;

                i++;

            }

            lblkalan.Text = kalan.ToString();

            lblgecen.Text = gecen.ToString();
            lblsınort.Text = (from DataGridViewRow row in dataGridView1.Rows where row.Cells[7].FormattedValue.ToString() != string.Empty select Convert.ToDecimal(row.Cells[7].FormattedValue)).Average().ToString("00.00");


        }


        private void btnogrkaydet_MouseHover(object sender, EventArgs e)
        {
            btnogrkaydet.BackColor = Color.DimGray;
        }

        private void btnsınavkydt_MouseHover(object sender, EventArgs e)
        {
            btnsınavkydt.BackColor = Color.DimGray;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DimGray;
        }

        private void btnogrkaydet_MouseLeave(object sender, EventArgs e)
        {
            btnogrkaydet.BackColor = Color.White;
        }

        private void btnsınavkydt_MouseLeave(object sender, EventArgs e)
        {
            btnsınavkydt.BackColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }



        private void btnsil_MouseHover(object sender, EventArgs e)
        {
            btnsil.BackColor = Color.Maroon;
        }

        private void btnsil_MouseLeave(object sender, EventArgs e)
        {
            btnsil.BackColor = Color.White;
        }
        
        private void btnsil_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Delete from TBLOGR where OGRNUMARA=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", msknumara.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(" Öğrenci Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.tBLOGRTableAdapter.Fill(this.dersNotKayıtDataSet.TBLOGR);
        }

    } 
}

