using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_systeme_securite
{
    public interface gerer_droit_acces
    {
        void ajouter_perssone(string username,string mot_passe);
        void suppremer_perssone();
        (string, string) check_accept();

    }
}
