using ClientWpf.Model;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ClientWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ClienrSocket cs = null;
        private static MonoClientTcp mono = new MonoClientTcp();
        public MainWindow()
        {
            InitializeComponent();
            Loaded += (sender, e) =>
            {
                outRes += Print;
                TbInput.Text = "hello";                
            };
        }

        private void Print(string obj)
        {
            if (!string.IsNullOrEmpty(obj))
            {
                Dispatcher.BeginInvoke((ThreadStart)delegate ()
                {
                    tbOut.Text = obj;
                });
            }
        }

        public Action<string> outRes;
        static int numCount = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string msg = TbInput.Text;
            Task.Run(() =>
            {
                mono.StartClient(msg, outRes);
            });
        }
    }
}
