using ems2.ViewModel;
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

namespace ems2.Views
{
    /// <summary>
    /// jjmain.xaml 的交互逻辑
    /// </summary>
    public partial class jjmain : Window
    {
        public jjmain()
        {
            InitializeComponent();
            JjmainViewModel viewModel = new JjmainViewModel();
            viewModel.Query();
            this.DataContext = viewModel;
        }
    }
}
