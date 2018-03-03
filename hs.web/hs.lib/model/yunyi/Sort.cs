namespace hs.lib.model.yunyi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Sort")]
    public partial class Sort
    {
        public Guid Id { get; set; }

        [StringLength(40)]
        public string SortNo { get; set; }

        [StringLength(40)]
        public string SortName { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        public Guid? ParentId { get; set; }

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
