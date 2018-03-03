namespace hs.lib.model.yunyi
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AttachFile")]
    public partial class AttachFile
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string AttachName { get; set; }

        [StringLength(200)]
        public string StoreLocation { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        public Guid? RosourceId { get; set; }

        public long? DownloadCount { get; set; }

        [StringLength(200)]
        public string Definition1 { get; set; }

        [StringLength(200)]
        public string Definition2 { get; set; }
    }
}
