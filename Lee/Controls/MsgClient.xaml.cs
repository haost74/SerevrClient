using ServerSocket.src.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lee.Controls
{
    /// <summary>
    /// Логика взаимодействия для MsgClient.xaml
    /// </summary>
    public partial class MsgClient : UserControl
    {
        public MsgClient()
        {
            DataContext = new MsgClientModel();
            InitializeComponent();
            IsVisibleChanged += ScheduleUserControl_IsVisibleChanged;
        }


        public MsgClientModel GetDataContext
        {
            get { return (MsgClientModel)DataContext; }
        }

        private void ScheduleUserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(IsVisible)
            {

            }else
            {

            }
        }

        private void Button_Send(object sender, RoutedEventArgs e)
        {
            if(GetDataContext.Client != null && GetDataContext.Client.workSocket != null && !string.IsNullOrEmpty(GetDataContext.MsgToServer))
            {
                GetDataContext.Client.Send(GetDataContext.MsgToServer);
            }
        }
    }
}
