using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void BtnHastaGiris_Click(object sender, EventArgs e)
        {
            FrmHastaGiris hst = new FrmHastaGiris();
            hst.Show();
            this.Hide();
        }

        private void BtnDoktorGiris_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris dktr = new FrmDoktorGiris();
            dktr.Show();
            this.Hide();
        }

        private void BtnSekreterGiris_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris skrtr = new FrmSekreterGiris();
            skrtr.Show();
            this.Hide();
        }
    }
}
