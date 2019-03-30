using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company();
            Console.WriteLine(company[2]);
            company[2] = "Igor";
            Console.WriteLine(company[2]);
            var paha = company["pavel"];
        }
    }

    class Company
    {
        private readonly List<Employee> _companyEmployees;

        public Company()
        {
            this._companyEmployees = new List<Employee>();
            _companyEmployees.Add(new Employee(){Gender = "male" , Id = 0, Name = "pavel"});
            _companyEmployees.Add(new Employee() { Gender = "female", Id = 1, Name = "irka" });
            _companyEmployees.Add(new Employee() { Gender = "male", Id = 2, Name = "genya" });
            _companyEmployees.Add(new Employee() { Gender = "female", Id = 3, Name = "katya" });
            _companyEmployees.Add(new Employee() { Gender = "male", Id = 4, Name = "kiros" });
            _companyEmployees.Add(new Employee() { Gender = "female", Id = 5, Name = "shegique" });
        }

        //get or set Name by Id
        public string this[int id]
        {
            get { return _companyEmployees.FirstOrDefault(emp => emp.Id == id).Name;}
            set { _companyEmployees.FirstOrDefault(emp => emp.Id == id).Name = value; }
        }

        //get Employee by Name
        public Employee this[string name]
        {
            get { return _companyEmployees.FirstOrDefault(emp => emp.Name == name); }
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
