namespace hs.lib.model.yunyi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public Guid Id { get; set; }

        [Key]
        [StringLength(40)]
        public string CustomerNo { get; set; }

        [StringLength(40)]
        public string CustomerName { get; set; }

        [StringLength(40)]
        public string ContactName { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        [StringLength(200)]
        public string Definition1 { get; set; }

        [StringLength(200)]
        public string Definition2 { get; set; }
    }
}
