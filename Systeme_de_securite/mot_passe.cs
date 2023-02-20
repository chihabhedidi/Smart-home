using Interfaces_systeme_securite;
using System;
using System.Runtime.Remoting;

namespace Systeme_de_securite
{
    public partial class mot_passe : DevExpress.XtraEditors.XtraForm
    {
        public gerer_droit_acces gerer_droit_acces;
       
        public mot_passe(string username)
        {
           
            gerer_droit_acces = (gerer_droit_acces)RemotingServices.Connect(typeof(gerer_droit_acces), "tcp://localhost:8080/securite");
            InitializeComponent();
            label2.Text = username;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            gerer_droit_acces.ajouter_perssone(label2.Text, textEdit1.Text);
           
            Close();
        }
    }
    
}