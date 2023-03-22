using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
using WpfApp1.KRINGEDataSetTableAdapters;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        PersonTableAdapter person = new PersonTableAdapter();
        public Window2()
        {
            InitializeComponent();
            plp_.ItemsSource = person.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                person.DeleteQuery((int)(plp_.SelectedItem as DataRowView).Row[0]);
            }
            catch
            {
                MessageBox.Show("Этот ключ используется в другой таблице");
            }
            plp_.ItemsSource = person.GetData();
        }
    }
}