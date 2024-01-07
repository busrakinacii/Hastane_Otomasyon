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


namespace Proje_Hastane
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
       
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@d1 and DoktorSifre=@d2", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", MskTcKimlikNo.Text);
            komut.Parameters.AddWithValue("@d2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.tc = MskTcKimlikNo.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bilgileriniz Eksik Yada Yanlıştır.Tekrar Deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
