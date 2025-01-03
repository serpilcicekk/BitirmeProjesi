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
    public partial class FrmDesigner : Form
    {
        public FrmDesigner()
        {
            InitializeComponent();
            dashboardDesigner1 = new DevExpress.DashboardWin.DashboardDesigner();
        }

        private void dashboardDesigner1_Load(string xmlFile)
        {
            dashboardDesigner1.LoadDashboard(xmlFile);



     
        }


    } 
}

