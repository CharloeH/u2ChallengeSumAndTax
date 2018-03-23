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
            int numOfLines;
            int.TryParse(Input.Substring(0, Input.IndexOf('\r')), out numOfLines);
           Input =  Input.Substring(Input.IndexOf("\r") + 2);
            double SubTotal = 0;
            double add = 0;
            double Tax;
            double Total;
            for (int i = 0; i < numOfLines; ++i)
            {
                double.TryParse(Input.Substring(0, Input.IndexOf("\r")), out add);
                SubTotal = SubTotal + add;
                
                
                    Input = Input.Substring(Input.IndexOf("\r") + 2);
                
                //MessageBox.Show(Input);
                //MessageBox.Show("10/10 ign would loop again");
                //MessageBox.Show(SubTotal.ToString());
            }
            MessageBox.Show(SubTotal.ToString());
            Tax = SubTotal * 0.13;
            MessageBox.Show(Tax.ToString());
            Total = SubTotal + Tax;
            lblOutput.Content = Total.ToString();

        }
    }
 }

