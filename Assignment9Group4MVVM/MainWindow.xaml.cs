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

namespace Assignment9Group4MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FeesCalculator fc;
        public MainWindow()
        {
            InitializeComponent();
            fc = new FeesCalculator();
            DataContext = fc;
            
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
           fc.GetTotalFees();
            DataContext = fc;
            TotalAmount ta = new TotalAmount(fc.TotalFees);
           
           ta.ShowDialog();
        }
    }
}
