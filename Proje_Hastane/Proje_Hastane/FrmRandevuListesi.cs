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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        public FrmSekreterDetay frm1;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           int  secilen = dataGridView1.SelectedCells[0].RowIndex;
            frm1.Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm1.MskTarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm1.MskSaat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm1.CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm1.CmbDoktor.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                    // frm1.ChkDurum.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            if ((bool)dataGridView1.Rows[secilen].Cells[5].Value){
                frm1.ChkDurum.Checked = true ;
            }
            else
            {
                frm1.ChkDurum.Checked = false;
            }
            frm1.MskTc.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            this.Hide();
        }
    }
}
