using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Formlar
{
    public partial class Dashboard : Form
    {
  
        private FrmDesigner frmDesigner;

        public Dashboard()
        {
            InitializeComponent();
    
            frmDesigner = new FrmDesigner();
        }

        private void viewer_Click(object sender, EventArgs e)
        {
            string fileName;
            openFileDialog1.ShowDialog();
            fileName = openFileDialog1.FileName;
         
        }

        private void ButtonDesigner_Click(object sender, EventArgs e)
        {
            frmDesigner.Show();
        }
    }
}
