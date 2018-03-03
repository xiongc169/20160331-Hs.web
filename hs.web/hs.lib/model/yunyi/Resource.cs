namespace hs.lib.model.yunyi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Resource")]
    public partial class Resource
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        [StringLength(20)]
        public string SubType { get; set; }

        [StringLength(40)]
        public string BusinessSystemNo { get; set; }

        [StringLength(40)]
        public string BusinessSystemName { get; set; }

        [StringLength(40)]
        public string CustomerNo { get; set; }

        [StringLength(40)]
        public string CustomerName { get; set; }

        [StringLength(40)]
        public string Creator { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(200)]
        public string Definition1 { get; set; }

        [StringLength(200)]
        public string Definition2 { get; set; }

        public bool? IsDelete { get; set; }
    }
}
