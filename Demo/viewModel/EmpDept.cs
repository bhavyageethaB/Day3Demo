using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.viewModel
{
    public class EmpDept
    {
        Employee emp = new Employee();

        public int EmpId
        {
            get { return emp.EmpId; }
            set { emp.EmpId = value; }
        }

        public string EmpName
        {
            get { return emp.EmpName; }
            set { emp.EmpName = value; }
        }

        Department dept = new Department();

        public string DeptName
        {
            get { return dept.DeptName; }
            set { dept.DeptName = value; }
        }
    }
}