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
    /// Логика взаимодействия для profileWin.xaml
    /// </summary>
    public partial class profileWin : Window
    {
        public profileWin(int t, BaseEmp r)
        {
            InitializeComponent();

            this.btn.Click += delegate
            {
                Console.WriteLine(r.EmployeesBase[t].NameEmp);
                r.EmployeesBase[t].NameEmp = txt.Text;
                txt.Clear();
            };
        }
    }
}
