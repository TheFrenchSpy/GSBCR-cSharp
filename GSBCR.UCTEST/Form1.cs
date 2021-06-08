using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBcr.modele;
using GSBCR.UC;
using GSBCR.BLL;

namespace GSBCR.UCTEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BSmedoc.DataSource = VisiteurManager.ChargerMedicaments();
            CBXmedoc.DataSource = BSmedoc;
            CBXmedoc.DisplayMember = "MED_NOMCOMMERCIAL";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucMedicament1.Visible = false;
            CBXmedoc.SelectedIndex = -1;
        }

        private void CBXmedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBXmedoc.SelectedIndex !=-1)
            {

            }
        }
    }
}
