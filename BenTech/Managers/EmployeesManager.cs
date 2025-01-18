using BenTech.Models;
using System;
using System.Collections.Generic;

namespace BenTech.Managers
{
    class EmployeesManager
    {
        private readonly DatabaseRepository _databaseRepository;

        public EmployeesManager(DatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }

        public List<Employees> GetAllEmployees()
        {
            return _databaseRepository.GetAllEmployees();
        }
        public bool AddEmployee(string name, string password, bool isAdmin)
        {
            return _databaseRepository.AddEmployee(name, password, isAdmin);
        }

        public bool DeleteEmployee(Int32 id)
        {
            return _databaseRepository.DeleteEmployee(id);
        }

        public Employees GetEmployeeById(int id) {
           return _databaseRepository.GetEmployeeById(id);
        }
        public bool UpdateEmployee(int employeeId, string name, string password, bool isAdmin)
        {
            return _databaseRepository.UpdateEmployee(employeeId, name, password, isAdmin);
        }
    }

}
