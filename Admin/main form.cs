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
using Interface_systeme_temp_humi;

using System.Threading;
namespace Admin
{
    public partial class main_form : Form
    {
        public Gestion_scurité gestion_securite;
        public Acces_maison Acces_maison;
        public gerer_temp_humid gerer_temp_humid;
        public main_form()
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);
            gestion_securite = (Gestion_scurité)RemotingServices.Connect(typeof(Gestion_scurité), "tcp://localhost:8080/securite");
            Acces_maison = (Acces_maison)RemotingServices.Connect(typeof(Acces_maison), "tcp://localhost:8080/securite");
            gerer_temp_humid = (gerer_temp_humid)RemotingServices.Connect(typeof(gerer_temp_humid), "tcp://localhost:8081/temp_humid");
            new Thread(new ThreadStart(WaitForClientInteraction)).Start();
        
            InitializeComponent();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Systeme_de_securite.cam form_acces = new Systeme_de_securite.cam();
            form_acces.Show();


        }

        private void main_form_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gestion_securite.change_etat_port();
            if (gestion_securite.verifier_etat_porte() == false)
            {

                simpleButton3.Text = "Porte: fermer";
                simpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            }
            else
            {
                simpleButton3.Text = "Porte: ouvert";
                simpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            }


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Systeme_de_securite.consulter_histo form_acces = new Systeme_de_securite.consulter_histo();
            form_acces.Show();

            
        }
        public void WaitForClientInteraction()
        {
            // Wait for the client to trigger the ClientButtonClicked event
            while (true)
            {
                if (Acces_maison.check_request() == true)
                {
                    MessageBox.Show("vous avez une nouvelle demande d'accès!");
                    
                }
                Thread.Sleep(1000);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Systeme_de_securite.gerer_acces form_acces = new Systeme_de_securite.gerer_acces();
            form_acces.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            systeme_temp_humid.temp_humid f = new systeme_temp_humid.temp_humid();
            f.Show();
        }
    } 
}
