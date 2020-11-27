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
using ServerSocket;

namespace Lee
{
    using Lee.ModelView;
    using ServerSocket.src.Server;
    using System.Threading;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainModel();
            InitializeComponent();

            Loaded += (sender, e) =>
            {
                StartServer();
            };
        }

        private void StartServer()
        {
            ServerMono serverMono = new ServerMono();
            ServerMono.ActionMsg += (msg) =>
            {
                Dispatcher.BeginInvoke((ThreadStart)delegate ()
                {
                    GetDataContext.Msg = msg;
                });
                
            };
            ServerMono.ActionData += (msg) =>
            {
                Dispatcher.BeginInvoke((ThreadStart)delegate ()
                {
                    //GetDataContext.Data += msg + "\r\n";
                });
            };

            ServerMono.ObservableClient += (obj) =>
            {
                var client = ((ObservableListClients)obj);
                if (client.TypeObservable == "add")
                {
                    Dispatcher.BeginInvoke((ThreadStart)delegate ()
                    {
                        if(GetDataContext != null && GetDataContext.ListClients != null)
                        GetDataContext.ListClients.Add(client.Cleent);
                        //if (GetDataContext.ListClients.Count == 1)
                        //    GetDataContext.Client = GetDataContext.ListClients[0];
                    });
                }
                else if (client.TypeObservable == "delete")
                {
                    Dispatcher.BeginInvoke((ThreadStart)delegate ()
                    {
                        if (GetDataContext != null && GetDataContext.ListClients != null)
                        {
                            if(GetDataContext.ListClients.Contains(client.Cleent))
                            GetDataContext.ListClients.Remove(client.Cleent);

                            //if(GetDataContext.Client == null && GetDataContext.ListClients.Count > 0)
                            //    GetDataContext.Client = GetDataContext.ListClients[0];

                            if (GetDataContext.ListClients == null || GetDataContext.ListClients.Count == 0 && CMsg.Visibility == Visibility.Visible)
                                CMsg.Visibility = Visibility.Collapsed;
                        }
                    });
                }
            };

            var t = serverMono.CreatedServer();
        }

        public MainModel GetDataContext { get { return (MainModel)DataContext; } }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (CMsg.Visibility == Visibility.Collapsed && GetDataContext.Client != null && GetDataContext.Client.workSocket != null &&
                GetDataContext.Client.workSocket.Connected)
                CMsg.Visibility = Visibility.Visible;
            else if (CMsg.Visibility == Visibility.Visible)
                CMsg.Visibility = Visibility.Collapsed;
        }
    }
}
