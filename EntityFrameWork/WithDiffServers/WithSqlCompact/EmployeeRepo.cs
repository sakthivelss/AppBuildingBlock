using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithSqlCompact
{
    public class EmployeeRepo
    {
        public Employees GetFirstEmployee()
        {

            NorthwindEntities context = new NorthwindEntities();
            return context.Employees.FirstOrDefault();
        }
    }
}
