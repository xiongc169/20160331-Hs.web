namespace hs.lib.model.yunyi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BusinessSystem")]
    public partial class BusinessSystem
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(40)]
        public string BusinessSystemNo { get; set; }

        [StringLength(40)]
        public string BusinessSystemName { get; set; }

        [StringLength(200)]
        public string Definition1 { get; set; }

        [StringLength(200)]
        public string Definition2 { get; set; }

        public bool? IsDelete { get; set; }
    }
}
