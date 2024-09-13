﻿using MVCProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.BLL.Interfaces
{
    public interface IEmployeeRepository
    {

        IEnumerable<Employee> GetAll();
        Employee GetById(int id);

        int Add(Employee department);

        int Update(Employee department);

        int Delete(Employee department);
    }
}
