using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systeme_de_securite
{
    class securite_implementation : MarshalByRefObject, Interfaces_systeme_securite.Acces_maison, Interfaces_systeme_securite.gerer_droit_acces, Interfaces_systeme_securite.Gestion_scurité
    {
        public bool etat_porte = true;//false = clsoed

            public bool request=false;
        string username_request = "";
        string motpasse_request = "";
        public bool refused = false;
        public void ajouter_perssone(string username,string mot_passe)
        {

            username_request = username;
            motpasse_request = mot_passe;
        }
        public (string, string) check_accept()
        {
            string us = username_request;
            string pw = motpasse_request;
            username_request = "";
            motpasse_request = "";
            return (us, pw);
        }
    public void consulter_cam()
        {

            cam form = new cam();
            form.Show();
        }

        public void consulter_historique_persone()
        {
            consulter_histo form = new consulter_histo();
            form.Show();
        }

        public void Demander_acces_porte()
        {

            request=true;

            
        }
        public bool check_request() {
            if(request==true){
            request=false;
            return !request;
}
            return false;
        }
        
        public void suppremer_perssone()
        {
            refused = true;
        }
        public void change_etat_port()
        {
            etat_porte = !etat_porte;
        }
        public bool verifier_etat_porte()
        {
            
            return etat_porte;
        }
    }
}
