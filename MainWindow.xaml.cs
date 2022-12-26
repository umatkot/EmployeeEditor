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

namespace EmployeeEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            EmployeeEditor.EmployeeDbDataSet employeeDbDataSet = ((EmployeeEditor.EmployeeDbDataSet)(this.FindResource("employeeDbDataSet")));
            // Load data into the table Departments. You can modify this code as needed.
            EmployeeEditor.EmployeeDbDataSetTableAdapters.DepartmentsTableAdapter employeeDbDataSetDepartmentsTableAdapter = new EmployeeEditor.EmployeeDbDataSetTableAdapters.DepartmentsTableAdapter();
            employeeDbDataSetDepartmentsTableAdapter.Fill(employeeDbDataSet.Departments);
            System.Windows.Data.CollectionViewSource departmentsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("departmentsViewSource")));
            departmentsViewSource.View.MoveCurrentToFirst();
            // Load data into the table Employeers. You can modify this code as needed.
            EmployeeEditor.EmployeeDbDataSetTableAdapters.EmployeersTableAdapter employeeDbDataSetEmployeersTableAdapter = new EmployeeEditor.EmployeeDbDataSetTableAdapters.EmployeersTableAdapter();
            employeeDbDataSetEmployeersTableAdapter.Fill(employeeDbDataSet.Employeers);
            System.Windows.Data.CollectionViewSource departmentsEmployeersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("departmentsEmployeersViewSource")));
            departmentsEmployeersViewSource.View.MoveCurrentToFirst();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDbDataSet db = new EmployeeDbDataSet();

            var department = new Departments();

            department.Name = 
        }
    }
}
