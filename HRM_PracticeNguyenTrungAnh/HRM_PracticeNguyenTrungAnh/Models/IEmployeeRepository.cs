﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM_PracticeNguyenTrungAnh.Models
{
    public interface IEmployeeRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
