using Microsoft.Win32;
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

namespace Calculator.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainCalcWindowViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm = new MainCalcWindowViewModel(new FileProvider());
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            var openFileBox = new OpenFileDialog();
            openFileBox.Filter = "Excel Files (*.xlsx)|*.xlsx";
            openFileBox.Title = "Locate Excel Files";
            openFileBox.Multiselect = false;
            if(openFileBox.ShowDialog() ?? false)
            {
                vm.ImportFilePath = openFileBox.FileName;
            }
        }
    }
}
