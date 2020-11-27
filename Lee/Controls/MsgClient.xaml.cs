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
            InitializeComponent();
            IsVisibleChanged += ScheduleUserControl_IsVisibleChanged;
        }

        private void ScheduleUserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(IsVisible)
            {

            }else
            {

            }
        }
    }
}
