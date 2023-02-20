using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systeme_temp_humid
{
    class systeme_temp_humid_imp : MarshalByRefObject, Interface_systeme_temp_humi.gerer_temp_humid
    {
        public void consulter_temp_humid()
        {
            
            temp_humid form = new temp_humid();
            form.Show();
        }
    }
}
