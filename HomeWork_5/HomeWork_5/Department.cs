using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HomeWork_5
{
    public class Department: INotifyPropertyChanged
    {
        int depNumb;
        string depName;
        public string DepName
        {
            get { return this.depName; }
            set {
                this.depName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.DepName)));      
                }
        }
        public int DepNumb { get; set; }

        public Department(string Name, int Id)
        {
            DepName = Name;
            DepNumb = Id;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
