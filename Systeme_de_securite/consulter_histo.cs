using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systeme_de_securite
{
    public partial class consulter_histo : DevExpress.XtraEditors.XtraForm
    {
        public consulter_histo()
        {
            InitializeComponent();
        }

        private void consulter_histo_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'poc_projectDataSet.historiques'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.historiquesTableAdapter.Fill(this.poc_projectDataSet.historiques);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}