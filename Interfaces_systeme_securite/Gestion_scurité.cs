using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_systeme_securite
{
    public interface Gestion_scurité
    {
        void consulter_cam();
        void consulter_historique_persone();
        bool verifier_etat_porte();
        void change_etat_port();
        
    }
}
