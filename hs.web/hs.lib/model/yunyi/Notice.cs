namespace hs.lib.model.yunyi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Notice")]
    public partial class Notice
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        [StringLength(20)]
        public string Level { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        public Guid? AttachId { get; set; }

        [StringLength(40)]
        public string Creator { get; set; }

        public DateTime? CreateTime { get; set; }

        public bool? Status { get; set; }

        [StringLength(40)]
        public string Publishor { get; set; }

        public DateTime? PublishTime { get; set; }

        public bool? IsTop { get; set; }

        public bool? IsEmailNotify { get; set; }

        [StringLength(1000)]
        public string Receiver { get; set; }

        [StringLength(1000)]
        public string CopyTo { get; set; }

        [StringLength(200)]
        public string Definition1 { get; set; }

        [StringLength(200)]
        public string Definition2 { get; set; }

        public bool? IsDelete { get; set; }
    }
}
