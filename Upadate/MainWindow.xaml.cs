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


namespace Upadate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel.MainWindowViewModel model;
        public MainWindow()
        {
            InitializeComponent();
            model = new MainViewModel.MainWindowViewModel();
            this.DataContext = model;
            this.Resources.Add("ModelWidoku", model);
        }

        private void Opcje1_Copy_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            
        }

        private void Opcje_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }
    }
}
