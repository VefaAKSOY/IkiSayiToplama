using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikiSayiToplama
{
    public partial class frmIkiSayiToplama : Form
    {
        public frmIkiSayiToplama()
        {
            InitializeComponent();
        }
        private int Topla(int birinciSayi,int ikinciSayi)
        {
            return birinciSayi + ikinciSayi;
        }
        
        private void EkranHazirla()
        {
            txtBirinciSayi.Text = txtİkinciSayi.Text = "0";
            txtBirinciSayi.Focus();
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {

            if ((txtBirinciSayi.Text == "") || (txtİkinciSayi.Text == ""))
            {
                MessageBox.Show("LÜTFEN DEĞER GİRİNİZ!");
                EkranHazirla();
            }
            else
            {
                txtToplam.Text = Convert.ToString(Topla(Convert.ToInt32(txtBirinciSayi.Text), Convert.ToInt32(txtİkinciSayi.Text)));
                lstToplamaLoglama.Items.Add("Toplama İşlemi sonucu: " + txtToplam.Text);
                EkranHazirla();
            }
        }

        private void frmIkiSayiToplama_Shown(object sender, EventArgs e)
        {
            EkranHazirla();
        }

        private void txtBirinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtİkinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbpLoglama;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbpToplama;
        }
    }

}
