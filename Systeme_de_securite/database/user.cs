namespace Systeme_de_securite.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        public int id { get; set; }

        
        public string username { get; set; }

        
        public string type { get; set; }

        
        public string mot_passe { get; set; }
    }
}
