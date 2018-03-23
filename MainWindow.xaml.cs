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

namespace u2ChallengeSumAndTaxSebastian
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

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            string Input = txtInput.Text;
            int.TryParse(Input.Substring(0, Input.IndexOf('\r')), out int numOfLines);
            for (int i = 0; i < numOfLines; ++i)
            {
                MessageBox.Show("10/10 ign would loop again");
            }
        }
    }
 }

