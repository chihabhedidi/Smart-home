namespace Systeme_de_securite.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class historique
    {
        public int id { get; set; }

        public DateTime? date { get; set; }

        public int? user_id { get; set; }

        [StringLength(50)]
        public string username { get; set; }
    }
}
