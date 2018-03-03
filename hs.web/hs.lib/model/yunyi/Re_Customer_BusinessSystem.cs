namespace hs.lib.model.yunyi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Re_Customer_BusinessSystem
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(40)]
        public string CustomerNo { get; set; }

        [StringLength(40)]
        public string CustomerName { get; set; }

        [StringLength(40)]
        public string BusinessSystemNo { get; set; }

        [StringLength(20)]
        public string BusinessSystemName { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(200)]
        public string Definition1 { get; set; }

        [StringLength(200)]
        public string Definition2 { get; set; }
    }
}
