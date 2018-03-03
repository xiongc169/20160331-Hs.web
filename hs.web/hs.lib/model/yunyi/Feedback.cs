namespace hs.lib.model.yunyi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Feedback")]
    public partial class Feedback
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [StringLength(40)]
        public string ContactName { get; set; }

        [StringLength(40)]
        public string Phone { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(40)]
        public string CustomerNo { get; set; }

        [StringLength(40)]
        public string CustomerName { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(2000)]
        public string Answer { get; set; }

        [StringLength(40)]
        public string Dealor { get; set; }

        public DateTime? DealTime { get; set; }

        public bool? Status { get; set; }

        [StringLength(200)]
        public string Definition1 { get; set; }

        [StringLength(200)]
        public string Definition2 { get; set; }

        public bool? IsDelete { get; set; }
    }
}
