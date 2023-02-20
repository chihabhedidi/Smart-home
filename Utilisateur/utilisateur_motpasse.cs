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
using Systeme_de_securite.database;
using Systeme_de_securite.function;
using Utilisateur;

namespace Systeme_de_securite
{
    public partial class utilisateur_motpasse : DevExpress.XtraEditors.XtraForm
    {
        string username;
        
        public utilisateur_motpasse(string name)
        {
            username = name;
            
            InitializeComponent();
            this.Text = username;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == "")
            {

                MessageBox.Show("enter votre mot de passe", "error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEdit1.Focus();

            }
            else
            {
                if (shared.db.users.Any(a => a.username == username && a.mot_passe == textEdit1.Text) == true)
                {
                    this.Hide();
                    MessageBox.Show("Welcome to home", "porte ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    try
                    {
                        historique histo = new historique();
                        histo.username = username;
                        histo.date = DateTime.Now;


                        shared.db.historiques.Add(histo);
                        shared.db.SaveChanges();



                    }
                    catch (Exception ex)
                    {

                    }
                    
                    ent form = new ent();
                    form.ShowDialog();

                }
                else
                {
                    MessageBox.Show("mauvais mot de passe ", "error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textEdit1.Focus();
                }


            }
        }
    }
}