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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace HomeWork_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BaseEmp data;
        public MainWindow()
        {
            InitializeComponent();

            data = new BaseEmp(10, 100);

            this.DataContext = data;
            EditBtn.Click += delegate
            {
                Debug.WriteLine((DepartCollectList.SelectedItem as Department).DepNumb);
                new WinEditDep((DepartCollectList.SelectedItem as Department).DepNumb, data).ShowDialog();
            };

            EmployeeCollectList.MouseDoubleClick += EmployeeCollectList_MouseDoubleClick;
        }

        private void EmployeeCollectList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            new profileWin(
                data.EmployeesBase.IndexOf((EmployeeCollectList.SelectedItem as Employee)), data).ShowDialog();
        }

        private void cmdDept_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EmployeeCollectList.ItemsSource = data.EmployeesBase.Where(
                w => w.DepNumb == (DepartCollectList.SelectedValue as Department)?.DepNumb
              );
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { data.DeleteDepartament((DepartCollectList.SelectedValue as Department).DepNumb); }

    }
}
