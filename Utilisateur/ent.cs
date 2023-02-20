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
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Interface_systeme_temp_humi;
using Systeme_de_securite.function;

namespace Utilisateur
{
    public partial class ent : DevExpress.XtraEditors.XtraForm
    {
        public gerer_temp_humid gerer_temp_humid;
        public ent()
        {
            gerer_temp_humid = (gerer_temp_humid)RemotingServices.Connect(typeof(gerer_temp_humid), "tcp://localhost:8081/temp_humid");
            
            InitializeComponent();
            this.Text = username.name;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            systeme_temp_humid.temp_humid f = new systeme_temp_humid.temp_humid();
            f.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ent_FormClosed(object sender, FormClosedEventArgs e)
        {
            var user = shared.db.users.First(a => a.username == username.name);
            if (user.type == "ami")
            {
                shared.db.users.Remove(user);
                shared.db.SaveChanges();
            }
        }
    }
}