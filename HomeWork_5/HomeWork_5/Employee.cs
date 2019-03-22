using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HomeWork_5
{
    public class Employee:INotifyPropertyChanged
    {
        public string NameEmp
        { get => nameEmp;
                set
            {
                nameEmp = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.NameEmp)));
            }
        }

        public string nameEmp;
        public int DepNumb { get; private set; }

        public Employee(string NameE, int DepN)
        {
            nameEmp = NameE;
            this.DepNumb = DepN;
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return $"{nameEmp,10}{DepNumb,3}";
        }
    }
}
