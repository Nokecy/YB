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
using ZdfFlatUI;

namespace YB
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.lastButton.Click += LastButton_Click;
            this.nextButton.Click += NextButton_Click;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 设置全屏    
            this.WindowState = System.Windows.WindowState.Normal;
            this.WindowStyle = System.Windows.WindowStyle.None;
            this.ResizeMode = System.Windows.ResizeMode.NoResize;
            this.Topmost = true;

            this.Left = 0.0;
            this.Top = 0.0;
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            this.tabControl.SelectedIndex = this.tabControl.SelectedIndex + 1;
            this.stepBar.Progress++;
        }

        private void LastButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.tabControl.SelectedIndex - 1 >= 0)
            {
                this.tabControl.SelectedIndex = this.tabControl.SelectedIndex - 1;
                this.stepBar.Progress--;
            }
        }

        private void StepBarItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var obj = (StepBarItem)sender;
            var number = int.Parse(obj.Number) - 1;
            this.stepBar.Progress = number;
            this.tabControl.SelectedIndex = number;
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
