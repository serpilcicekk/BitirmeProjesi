using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmDepartmanlar : Form
    {
        public FrmDepartmanlar()
        {
            InitializeComponent();
        }
        DbisTakipEntities4 db = new DbisTakipEntities4();
        void Listele()
        {
            var degerler = (from x in db.TblDepartmanlar
                            select new
                            {
                                x.ID,
                                x.Ad
                            }).ToList();


            gridControl1.DataSource = degerler;
        }
        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblDepartmanlar t = new TblDepartmanlar();
            t.Ad = TxtAd.Text;
            db.TblDepartmanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtId.Text);
            var deger = db.TblDepartmanlar.Find(x);
            db.TblDepartmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Depatman silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtId.Text);
            var deger = db.TblDepartmanlar.Find(x);
            deger.Ad = TxtAd.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Depatman güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void FrmDepartmanlar_Load(object sender, EventArgs e)
        {

        }
    }
}
