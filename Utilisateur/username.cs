using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using Systeme_de_securite.function;
using Systeme_de_securite.database;

namespace Utilisateur
{
    
    public partial class username : DevExpress.XtraEditors.XtraForm
    {
        public static string name;
        public username()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (username_box.Text == "" )
            {
                
                    MessageBox.Show("enter un votre nom", "error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username_box.Focus();
                
            }
            else
            {
                if (shared.db.users.Any(a => a.username == username_box.Text   ) == true)
                {
                    name = username_box.Text;
                    MessageBox.Show("Welcome to smart home", "Login ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    
                }
                else
                {
                    MessageBox.Show("nom d'utilisateur ne pas trouver, registrer ", "error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username_box.Focus();
                }


            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (username_box.Text == "")
            {

                MessageBox.Show("enter un votre nom", "error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username_box.Focus();

            }
            else
            {
                if (shared.db.users.Any(a => a.username == username_box.Text) == true)
                {

                    MessageBox.Show("nom d'utilisateur déjà pris, essayez-en un autre", "error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username_box.Focus();
                }
                else
                {
                    try
                    {
                        name = username_box.Text;
                        user user = new user();
                        user.username = username_box.Text;
                        if(ami.Checked)
                        user.type = "ami";
                        else
                        user.type = "famille";
                        shared.db.users.Add(user);
                        shared.db.SaveChanges();
                        MessageBox.Show("Welcome to smart home", "Registre ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        
                    }
                    catch
                    {
                    }
                }


            }
           
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}