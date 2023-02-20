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
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Interfaces_systeme_securite;
using Microsoft.VisualBasic;
using Systeme_de_securite.function;
using Systeme_de_securite.database;
using System.Threading;
using Systeme_de_securite;

namespace Utilisateur
{
    public partial class Form1 : Form
    {
        public Acces_maison Acces_maison;
        public gerer_droit_acces gerer_droit_acces;
        public Gestion_scurité gestion_securite;
        int refused = 0;
        public Form1()
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);
            Acces_maison = (Acces_maison)RemotingServices.Connect(typeof(Acces_maison), "tcp://localhost:8080/securite");
            gestion_securite = (Gestion_scurité)RemotingServices.Connect(typeof(Gestion_scurité), "tcp://localhost:8080/securite");
            gerer_droit_acces = (gerer_droit_acces)RemotingServices.Connect(typeof(gerer_droit_acces), "tcp://localhost:8080/securite");

            new Thread(new ThreadStart(WaitForClientInteraction)).Start();
            
            InitializeComponent();
            username f = new username();
            this.Text = username.name;
            f.ShowDialog();
            if (shared.db.users.Any(a => a.username == username.name && a.mot_passe != null) == true)
            {

                simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
                simpleButton1.Text = "votre mot de passe";
            }



        }
        public void mot_passe_done()
        {
            simpleButton1.Invoke((MethodInvoker)delegate
            {
                simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
                simpleButton1.Text = "votre mot de passe";
            });
            
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (simpleButton1.Text == "votre mot de passe")
            {
                try
                {
                    var user = shared.db.users.First(a => a.username == username.name);
                    MessageBox.Show("votre mot de passe est " + user.mot_passe);
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                try
                {
                    request request = new request();
                    request.username = username.name;
                    request.request_date = DateTime.Now;
                    gerer_droit_acces.ajouter_perssone("", "");

                    shared.db.requests.Add(request);
                    shared.db.SaveChanges();
                    Acces_maison.Demander_acces_porte();
                    if (refused == 1)
                    {
                        new Thread(new ThreadStart(WaitForClientInteraction)).Start();
                    }

                    MessageBox.Show("Request sent", "Smart home", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                }
            }
        }
        public void WaitForClientInteraction()
        {
            // Wait for the client to trigger the ClientButtonClicked event
            while (true)
            {
                (string username_sent, string password) = gerer_droit_acces.check_accept();
                if (username_sent == username.name)
                {
                    
                    MessageBox.Show("votre mot de passe est " + password);
                    var user = shared.db.users.First(a => a.username == username.name);
                    user.mot_passe = password;
                    shared.db.SaveChanges();
                    mot_passe_done();
                    break;
                }
                else
                {
                    if (username_sent == username.name + "refused")
                    {
                        MessageBox.Show("demande refusée ,réessayer ");
                        refused = 1;
                        break;
                    }

                }
                Thread.Sleep(1000);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var user = shared.db.users.First(a => a.username == username.name);
                if (user.type == "ami")
                {
                    shared.db.users.Remove(user);
                    shared.db.SaveChanges();
               
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gestion_securite.verifier_etat_porte() == true)
            {
                this.Hide();
                ent form = new ent();
                try
                {
                    historique histo = new historique();
                    histo.username = username.name;
                    histo.date = DateTime.Now;


                    shared.db.historiques.Add(histo);
                    shared.db.SaveChanges();



                }
                catch (Exception ex)
                {

                }
                form.Show();
            }
            else
            {
                var user = shared.db.users.First(a => a.username == username.name);
                if (user.mot_passe == null)
                {
                    MessageBox.Show("demander un mot passe  ");
                }
                else
                {
                    utilisateur_motpasse form2 = new utilisateur_motpasse(username.name);
                    form2.ShowDialog();
                }
                
            }
            
        }
    }
}
