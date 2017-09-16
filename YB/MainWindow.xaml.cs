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
    }
}
