using DevExpress.XtraEditors;
using is_takip_proje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelGorevFormlar.FrmPersonelFormu fr = new PersonelGorevFormlar.FrmPersonelFormu();
            fr.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hyperlinkLabelControl3_Click(object sender, EventArgs e)
        {

        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {

        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void hyperlinkLabelControl4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            panel4.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
        }
        DbisTakipEntities4 db = new DbisTakipEntities4();
        private void BtnAdminn_Click(object sender, EventArgs e)
        {
            var adminvalue = db.TblAdmin.Where(x => x.Kullanici == TxtKullanici.Text &&
              x.Sifre == TxtSifre.Text).FirstOrDefault();
            if(adminvalue !=null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();

            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }

        private void BtnPersonell_Click(object sender, EventArgs e)
        {
            var personel = db.TblPersonel.Where(x => x.Mail == TxtKullanici.Text &&
              x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (personel != null)
            {
                PersonelGorevFormlar.FrmPersonelFormu fr = new PersonelGorevFormlar.FrmPersonelFormu();
                fr.mail = TxtKullanici.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }
    }
    }

