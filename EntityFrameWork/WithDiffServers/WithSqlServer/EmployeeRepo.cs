using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithSqlServer
{
    public class EmployeeRepo
    {
        public Employee GetFirstEmployee()
        {

            NorthwindEntities context = new NorthwindEntities();
            return context.Employees.FirstOrDefault();
        }
    }
}
