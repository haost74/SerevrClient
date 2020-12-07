using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using ClietTest.Model;
using ServerSocket.src.Client;

namespace ClietTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new ClientModel();
            InitializeComponent();
        }

        public ClientModel GetDataContext
        {
            get { return (ClientModel)DataContext; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(GetDataContext.ClientM == null || !GetDataContext.ClientM.IsConnected)
            {
                GetDataContext.ClientM = new ClientMono(GetDataContext.Address, GetDataContext.Port);
                GetDataContext.ClientM.StartClient(GetDataContext.Msg, (ms) => 
                {
                    Dispatcher.BeginInvoke((ThreadStart)delegate () 
                    {
                        MessageBox.Show(ms);
                    });
                });
            }
            else
            if(!string.IsNullOrEmpty(GetDataContext.Msg))
            {
                GetDataContext.ClientM.Send(GetDataContext.Msg, (ms) => 
                {
                    Dispatcher.BeginInvoke((ThreadStart)delegate ()
                    {
                        MessageBox.Show(ms);
                    });
                });
            }
        }
    }
}
