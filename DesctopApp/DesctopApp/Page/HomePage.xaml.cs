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
using System.Windows.Threading;

namespace DesctopApp.Page
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

      

        private void TestRipple(object sender, MouseButtonEventArgs e)
        {
            ConnectLabel.Content = "Connecting...";
           
        }

        private void testCom(object sender, EventArgs e)
        {
            ConnectLabel.Content = "Connect";
        }

        
    }
}
