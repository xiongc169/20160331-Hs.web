using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.lib.model
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public string Hobby { get; set; }

        public string Remark { get; set; }
    }
}
