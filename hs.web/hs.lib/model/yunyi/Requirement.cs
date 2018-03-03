namespace hs.lib.model.yunyi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Requirement")]
    public partial class Requirement
    {
        public Guid Id { get; set; }

        [StringLength(40)]
        public string RequirementNo { get; set; }

        [StringLength(40)]
        public string CustomerNo { get; set; }

        [StringLength(40)]
        public string CustomerName { get; set; }

        [StringLength(40)]
        public string ContactName { get; set; }

        [StringLength(40)]
        public string Phone { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(40)]
        public string BusinessSystemNo { get; set; }

        [StringLength(40)]
        public string BusinessSystemName { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? Deadline { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(2000)]
        public string Answer { get; set; }

        [StringLength(40)]
        public string Dealor { get; set; }

        public DateTime? DealTime { get; set; }

        [StringLength(200)]
        public string Definition1 { get; set; }

        [StringLength(200)]
        public string Definition2 { get; set; }
    }
}
