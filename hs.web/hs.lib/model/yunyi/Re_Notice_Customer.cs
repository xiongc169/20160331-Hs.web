namespace hs.lib.model.yunyi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Re_Notice_Customer
    {
        public Guid Id { get; set; }

        public Guid? NoticeId { get; set; }

        [StringLength(40)]
        public string BusinessSystemNo { get; set; }

        [StringLength(40)]
        public string BusinessSystemName { get; set; }

        [StringLength(40)]
        public string CustomerNo { get; set; }

        [StringLength(40)]
        public string CustomerName { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Definition1 { get; set; }

        [StringLength(200)]
        public string Definition2 { get; set; }
    }
}
