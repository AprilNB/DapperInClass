using System;
using System.Collections.Generic;

namespace DapperInClass
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetAllDepartments(); 
    }
}
