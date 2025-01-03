
namespace is_takip_proje.Formlar
{
    partial class Dashboard
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
            this.ButtonDesigner = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ButtonDesigner
            // 
            this.ButtonDesigner.Location = new System.Drawing.Point(272, 106);
            this.ButtonDesigner.Name = "ButtonDesigner";
            this.ButtonDesigner.Size = new System.Drawing.Size(224, 133);
            this.ButtonDesigner.TabIndex = 1;
            this.ButtonDesigner.Text = "Designer";
            this.ButtonDesigner.UseVisualStyleBackColor = true;
            this.ButtonDesigner.Click += new System.EventHandler(this.ButtonDesigner_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonDesigner);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonDesigner;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}