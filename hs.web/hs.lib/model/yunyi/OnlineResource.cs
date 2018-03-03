namespace hs.lib.model.yunyi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OnlineResource")]
    public partial class OnlineResource
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(40)]
        public string Teacher { get; set; }

        [StringLength(40)]
        public string BusinessSystemNo { get; set; }

        [StringLength(40)]
        public string BusinessSystemName { get; set; }

        [StringLength(40)]
        public string Uploader { get; set; }

        public DateTime? UploadTime { get; set; }

        public Guid? AttachId { get; set; }

        public long? PlayCount { get; set; }

        [StringLength(200)]
        public string Definition1 { get; set; }

        [StringLength(200)]
        public string Definition2 { get; set; }

        public bool? IsDelete { get; set; }
    }
}
