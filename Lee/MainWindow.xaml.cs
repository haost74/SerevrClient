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
    using Lee.Controls;
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
            DataContext = new MainModel(this);
            InitializeComponent();

            Loaded += (sender, e) =>
            {
                GetDataContext.StartServer();
            };
        }
        
        public MainModel GetDataContext { get { return (MainModel)DataContext; } }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (CMsg.Visibility == Visibility.Collapsed && GetDataContext.Client != null && GetDataContext.Client.workSocket != null &&
                GetDataContext.Client.workSocket.Connected)
            {
                CMsg.GetDataContext.Init(GetDataContext.Client);
                CMsg.Visibility = Visibility.Visible;
            }
            else if (CMsg.Visibility == Visibility.Visible)
            {
                CMsg.Visibility = Visibility.Collapsed;
            }
        }
    }
}
