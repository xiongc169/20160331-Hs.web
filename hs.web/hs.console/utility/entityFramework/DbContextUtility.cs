using hs.lib.model.yunyi;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.utility.entityFramework
{
    public class DbContextUtility : DbContext
    {
        public DbContextUtility() : base("Demo")
        {
            try
            {
                //创建数据库
                //Database.CreateIfNotExists();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DbSet<AttachFile> AttachFile { get; set; }

        public DbSet<BusinessSystem> BusinessSystem { get; set; }

        public DbSet<CustomerEvent> CustomerEvent { get; set; }

        public DbSet<Feedback> Feedback { get; set; }

        public DbSet<Log_ResourceDownload> Log_ResourceDownload { get; set; }

        public DbSet<Notice> Notice { get; set; }

        public DbSet<OnlineResource> OnlineResource { get; set; }

        public DbSet<Re_Notice_Customer> Re_Notice_Customer { get; set; }

        public DbSet<Requirement> Requirement { get; set; }

        public DbSet<Resource> Resource { get; set; }

        public DbSet<Sort> Sort { get; set; }
    }
}
