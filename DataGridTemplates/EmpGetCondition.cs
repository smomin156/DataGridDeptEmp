using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DataGridTemplates
{
    class EmpGetCondition:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            TRAININGEntities db = new TRAININGEntities();
            if (value != null)
            {
                DEPT dept = value as DEPT;
                var query1 = (from emp in db.EMPs
                              where emp.DEPTNO == dept.DEPTNO
                              select new { Ename = emp.ENAME, Job = emp.JOB }).ToList();

                return query1;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
