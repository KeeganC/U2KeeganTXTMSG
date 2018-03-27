/*Keegan Chan
 * 3 26 2018
 * U2KeeganTXTMSG
 * Translates leetspeak
 */
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

namespace U2KeeganTXTMSG
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

        private void btnTranslate_Click(object sender, RoutedEventArgs e)
        {
            string strInput = txbInput.Text;
            string strOutput = strInput.Substring(0, strInput.IndexOf("TTYL") + 4);

            strOutput = strOutput.Replace("CUZ", " because ").Replace(":-)", " I'm happy ").Replace(":-(", " I'm unhappy ").Replace(";-)", " wink ").Replace(":-P", " stick my tongue out ").Replace("(~.~)", " sleepy ").Replace("TA", " totally awesome ").Replace("CCC", " Canadian Computation Competition ").Replace("CU", " see you ").Replace("YW", " you're welcome ").Replace("TTYL", " talk to you later").Replace("TY", " thank you ");
            txbOutput.Text = strOutput;
        }
    }
}
