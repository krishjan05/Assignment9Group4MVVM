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

namespace Assignment9Group4MVVM
{
    /// <summary>
    /// Interaction logic for TotalAmount.xaml
    /// </summary>
    public partial class TotalAmount : Window
    {
        FeesCalculator f = new FeesCalculator();
        public TotalAmount(int value)
        {
            f.TotalFees = value;
            InitializeComponent();
            DataContext = f;
        }
    }
}
