using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp1.KRINGEDataSetTableAdapters;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonDepartmentTableAdapter person = new PersonDepartmentTableAdapter();
        
        public MainWindow()
        {
            InitializeComponent();
            PersonDataGrid.ItemsSource = person.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person.DeleteQuery((int)(PersonDataGrid.SelectedItem as DataRowView).Row[0]);
            PersonDataGrid.ItemsSource = person.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 hipe = new Window1();
            hipe.ShowDialog();
        }
    }
}
