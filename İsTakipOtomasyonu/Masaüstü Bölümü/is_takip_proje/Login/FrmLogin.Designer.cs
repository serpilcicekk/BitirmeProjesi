
namespace is_takip_proje.Login
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControl2 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControl3 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControl4 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.BtnAdminn = new System.Windows.Forms.Button();
            this.BtnPersonell = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanici.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 316);
            this.panel1.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(100, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "İş Takip ve Yönetim Sistemi Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı Adı ve Şifrenizle Giriş Yapınız";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(12, 10);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(30, 30);
            this.pictureEdit2.TabIndex = 7;
            this.pictureEdit2.EditValueChanged += new System.EventHandler(this.pictureEdit2_EditValueChanged);
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(12, 3);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(30, 30);
            this.pictureEdit3.TabIndex = 8;
            this.pictureEdit3.EditValueChanged += new System.EventHandler(this.pictureEdit3_EditValueChanged);
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(42, 289);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(76, 13);
            this.hyperlinkLabelControl1.TabIndex = 9;
            this.hyperlinkLabelControl1.Text = "Şifremi Unuttum";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // hyperlinkLabelControl2
            // 
            this.hyperlinkLabelControl2.Location = new System.Drawing.Point(124, 289);
            this.hyperlinkLabelControl2.Name = "hyperlinkLabelControl2";
            this.hyperlinkLabelControl2.Size = new System.Drawing.Size(32, 13);
            this.hyperlinkLabelControl2.TabIndex = 10;
            this.hyperlinkLabelControl2.Text = "Yardım";
            this.hyperlinkLabelControl2.Click += new System.EventHandler(this.hyperlinkLabelControl2_Click);
            // 
            // hyperlinkLabelControl3
            // 
            this.hyperlinkLabelControl3.Location = new System.Drawing.Point(162, 289);
            this.hyperlinkLabelControl3.Name = "hyperlinkLabelControl3";
            this.hyperlinkLabelControl3.Size = new System.Drawing.Size(53, 13);
            this.hyperlinkLabelControl3.TabIndex = 11;
            this.hyperlinkLabelControl3.Text = "Web Paneli";
            this.hyperlinkLabelControl3.Click += new System.EventHandler(this.hyperlinkLabelControl3_Click);
            // 
            // hyperlinkLabelControl4
            // 
            this.hyperlinkLabelControl4.Location = new System.Drawing.Point(221, 289);
            this.hyperlinkLabelControl4.Name = "hyperlinkLabelControl4";
            this.hyperlinkLabelControl4.Size = new System.Drawing.Size(86, 13);
            this.hyperlinkLabelControl4.TabIndex = 12;
            this.hyperlinkLabelControl4.Text = "Uygulamayı Kapat";
            this.hyperlinkLabelControl4.Click += new System.EventHandler(this.hyperlinkLabelControl4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnPersonell);
            this.panel2.Controls.Add(this.BtnAdminn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.hyperlinkLabelControl4);
            this.panel2.Controls.Add(this.hyperlinkLabelControl3);
            this.panel2.Controls.Add(this.hyperlinkLabelControl2);
            this.panel2.Controls.Add(this.hyperlinkLabelControl1);
            this.panel2.Location = new System.Drawing.Point(359, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 316);
            this.panel2.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TxtSifre);
            this.panel4.Controls.Add(this.pictureEdit3);
            this.panel4.Location = new System.Drawing.Point(5, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 41);
            this.panel4.TabIndex = 14;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(48, 13);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(193, 20);
            this.TxtSifre.TabIndex = 15;
            this.TxtSifre.Click += new System.EventHandler(this.textEdit2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtKullanici);
            this.panel3.Controls.Add(this.pictureEdit2);
            this.panel3.Location = new System.Drawing.Point(5, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 45);
            this.panel3.TabIndex = 13;
            // 
            // TxtKullanici
            // 
            this.TxtKullanici.Location = new System.Drawing.Point(48, 20);
            this.TxtKullanici.Name = "TxtKullanici";
            this.TxtKullanici.Size = new System.Drawing.Size(193, 20);
            this.TxtKullanici.TabIndex = 14;
            this.TxtKullanici.Click += new System.EventHandler(this.textEdit1_Click);
            // 
            // BtnAdminn
            // 
            this.BtnAdminn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnAdminn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdminn.ForeColor = System.Drawing.Color.White;
            this.BtnAdminn.Location = new System.Drawing.Point(63, 174);
            this.BtnAdminn.Name = "BtnAdminn";
            this.BtnAdminn.Size = new System.Drawing.Size(193, 24);
            this.BtnAdminn.TabIndex = 15;
            this.BtnAdminn.Text = "ADMIN";
            this.BtnAdminn.UseVisualStyleBackColor = false;
            this.BtnAdminn.Click += new System.EventHandler(this.BtnAdminn_Click);
            // 
            // BtnPersonell
            // 
            this.BtnPersonell.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnPersonell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersonell.ForeColor = System.Drawing.Color.White;
            this.BtnPersonell.Location = new System.Drawing.Point(63, 211);
            this.BtnPersonell.Name = "BtnPersonell";
            this.BtnPersonell.Size = new System.Drawing.Size(193, 26);
            this.BtnPersonell.TabIndex = 16;
            this.BtnPersonell.Text = "PERSONEL";
            this.BtnPersonell.UseVisualStyleBackColor = false;
            this.BtnPersonell.Click += new System.EventHandler(this.BtnPersonell_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 356);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanici.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl2;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl3;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.TextEdit TxtSifre;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit TxtKullanici;
        private System.Windows.Forms.Button BtnAdminn;
        private System.Windows.Forms.Button BtnPersonell;
    }
}