using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBcr.modele;

namespace GSBCR.UC
{
    public partial class UcMedicament : UserControl
    {
        private MEDICAMENT LeMedicament;

        public MEDICAMENT LeMedicament1 { get => LeMedicament; set => LeMedicament = value; }

        public UcMedicament()
        {
            InitializeComponent();
        }

        private void UcMedicament_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ucMedicament_actualiser()
        {
            TB_depot.Text = LeMedicament.MED_DEPOTLEGAL;
            TB_nom.Text = LeMedicament

        }
    }
}
