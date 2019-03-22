using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace HomeWork_5
{
    public class BaseEmp
    {
        public ObservableCollection<Employee> EmployeesBase { get; set; }
        public ObservableCollection<Department> DepartmentBase { get; set; }
        static Random random = new Random();

        public void DeleteDepartament(int Index)
        {
            for(int i = EmployeesBase.Count - 1; i >= 0; i--)
            {
                if(EmployeesBase[i].DepNumb == Index)
                {
                    EmployeesBase.RemoveAt(i);
                }
            }
            for(int i = DepartmentBase.Count - 1; i >= 0; i--)
                if(DepartmentBase[i].DepNumb == Index)
                {
                    DepartmentBase.RemoveAt(i);
                }
        }

        public BaseEmp(int CountDepartament, int CountEmployee)
        {
            EmployeesBase = new ObservableCollection<Employee>();
            DepartmentBase = new ObservableCollection<Department>();

            for (int i = 0; i < CountDepartament; i++)
            {
                DepartmentBase.Add(new Department($"Департамент {i + 1}", i));
            }
            for(int i = 0; i < CountEmployee; i++)
            {
                EmployeesBase.Add(
                    new Employee($"Клон_{i + 1}",
                    random.Next(DepartmentBase.Count)));
            }
        }

    }
}
