using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hs.console.utility
{
    public class EntityFrameworkUtility
    {
        public static void EntityFrameworkTest()
        {
            //
            //string connecStrB = "metadata=res://*/NorthwindEF.csdl|res://*/NorthwindEF.ssdl|res://*/NorthwindEF.msl;provider=System.Data.SqlClient;provider connection string='data source=(local);initial catalog=Northwind;persist security info=True;user id=sa;password=111111;MultipleActiveResultSets=True;App=EntityFramework'";
            //string connecStr = "data source=(local);initial catalog=Northwind;persist security info=True;user id=sa;password=111111;";
            //ObjectContext oc = new ObjectContext(connecStr);
            //ObjectParameter[] param = new ObjectParameter[10];
            //ObjectQuery<Employees> oq = oc.CreateQuery<Employees>("select * from Employees");
            //IQueryable<Employees> employees = from e in oq select e;
            //Employees em = employees.First<Employees>();

            //ObjectStateEntry ose = null;
            //ObjectStateManager osm = null;

            //using (var edm = new NorthwindEntities())
            //{
            //    DbSet<Customers> customers = edm.Customers;
            //    IQueryable<Customers> cust1 = from c in customers where c.CustomerID == "ALFKI" select c;
            //}
        }
    }
}
