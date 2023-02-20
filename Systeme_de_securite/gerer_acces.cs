using DevExpress.XtraEditors;
using Interfaces_systeme_securite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Remoting;
using Systeme_de_securite.function;

namespace Systeme_de_securite
{
    public partial class gerer_acces : DevExpress.XtraEditors.XtraForm
    {
        public gerer_droit_acces gerer_droit_acces;

        public gerer_acces()
        {
            gerer_droit_acces = (gerer_droit_acces)RemotingServices.Connect(typeof(gerer_droit_acces), "tcp://localhost:8080/securite");

            InitializeComponent();
        }

        private void gerer_acces_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'poc_projectDataSet.requests'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.requestsTableAdapter.Fill(this.poc_projectDataSet.requests);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            mot_passe form = new mot_passe(username_function());
            form.ShowDialog();
           
            
        }
        public void change_color(DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e,Color c)
        {
            e.Appearance.BackColor = c;
        }
        public string username_function()
        {
            try
            {
                
                
                
                string username = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "username").ToString());
                return username;
            }
            catch
            {
                return "";
            }
            
        }
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            username_function();
            
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            
            gerer_droit_acces.ajouter_perssone(username_function() + "refused", "");


        }

        

       
    }
}