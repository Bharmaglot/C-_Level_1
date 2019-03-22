using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HomeWork_5
{
    /// <summary>
    /// Логика взаимодействия для WinEditDep.xaml
    /// </summary>
    public partial class WinEditDep : Window
    {
        public WinEditDep(int i, BaseEmp baseEmp)
        {
            InitializeComponent();
            Console.WriteLine(baseEmp.DepartmentBase[i].DepName);

            btn.Click += delegate
            {
                Console.WriteLine(baseEmp.DepartmentBase[i].DepName);
                baseEmp.DepartmentBase[i].DepName = txt.Text;
                this.DialogResult = true;
            };
        }
    }
}
