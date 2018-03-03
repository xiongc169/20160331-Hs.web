namespace hs.lib.model.yunyi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Log_ResourceDownload
    {
        public Guid Id { get; set; }

        public Guid ResourceId { get; set; }

        public Guid AttachId { get; set; }

        [StringLength(40)]
        public string CustomerNo { get; set; }

        [StringLength(40)]
        public string CustomerName { get; set; }

        public DateTime? DownloadTime { get; set; }

        [StringLength(40)]
        public string DownloadIP { get; set; }

        [StringLength(200)]
        public string Definition1 { get; set; }

        [StringLength(200)]
        public string Definition2 { get; set; }
    }
}
