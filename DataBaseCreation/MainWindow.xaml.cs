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
using System.Data.OleDb;

namespace DataBaseCreation
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Zohaib\Desktop\TestDataBase.accdb;Persist Security Info = False;";

            OleDbConnection connection = new OleDbConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Connection established");
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.ToString());
            }
            
        }
    }
}
