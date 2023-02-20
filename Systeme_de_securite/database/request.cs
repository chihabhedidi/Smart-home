namespace Systeme_de_securite.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class request
    {
        public int id { get; set; }

        [StringLength(10)]
        public string users_id { get; set; }

        public DateTime? request_date { get; set; }

        [StringLength(50)]
        public string username { get; set; }
    }
}
