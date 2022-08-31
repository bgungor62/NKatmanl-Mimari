using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLaayer;
using EntityLayer;
using LogicLayer;
using System.Data.SqlClient;
namespace NKatmanlıMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<Personel> Perlist = LogicPersonel.LLpersonellistesi();
            dataGridView1.DataSource = Perlist;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel ent = new Personel();// entity katmanından personel ssınıfını çağırdık 
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Gorevi = txtgorev.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            LogicPersonel.LLpersonelEkle(ent);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Personel ent = new Personel();
            ent.Id = int.Parse(txtid.Text);
            DALpersonel.PersonelSil(ent);


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Personel ent = new Personel();
            ent.Id = int.Parse(txtid.Text);
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Gorevi = txtgorev.Text;
            ent.Maas = short.Parse(txtmaas.Text);

            DALpersonel.PersonelGuncelle(ent);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtgorev.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtmaas.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();


        }
    }
}
