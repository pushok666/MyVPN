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
using DesctopApp.Page;

namespace DesctopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        DispatcherTimer timer;
        Thickness margin;
        double panelWidth;
        bool hidden;
        public MainWindow()
        {
            InitializeComponent();
            
            margin = WorkArea.Margin;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            timer.Tick += Timer_Tick;

            panelWidth = sidePanel.Width;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width += 16;
                WorkArea.Width -= 16;
                if (sidePanel.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = false;
                    FirstCol.Width = new GridLength(sidePanel.Width);
                }
            }
            else
            {
                sidePanel.Width -= 32;
                WorkArea.Width += 32;
                
                if (sidePanel.Width <= 70)
                {
                    timer.Stop();
                    hidden = true;
                    FirstCol.Width = new GridLength(sidePanel.Width);
                }
            }
        }

        private void PanelHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            timer.Start();
        }

        private void aboutEvent(object sender, MouseButtonEventArgs e)
        {
            DataContent.Content = new AboutPage();
        }

        private void homeEvent(object sender, MouseButtonEventArgs e)
        {
            DataContent.Content = new HomePage();
        }
    }
}
