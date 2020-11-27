using ServerSocket.src.Server;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace Lee.ModelView
{
    public class MainModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        #endregion
        private MainWindow win = null;
        public MainModel(MainWindow win)
        {
            this.win = win;
        }

        private string msg = "";
        public string Msg
        {
            get { return msg; }
            set
            {
                msg = value;
                OnPropertyChanged();
            }
        }

        private string data = "";
        public string Data
        {
            get { return data; }
            set
            {
                data = value;
                OnPropertyChanged();
            }
        }

        private DataServer client = new DataServer();
        public DataServer Client
        {
            get { return client; }
            set
            {
                client = value;
                if(client != null)
                {
                    var temps = client.GetMsgs();
                    
                    string str = "";
                    for (int i = 0; i < temps.Count; ++i)
                    {
                        str += temps[i] + "\r\n";
                    }
                    Data = str;
                }
                OnPropertyChanged();
            }
        }

        private ObservableCollection<DataServer> listClients =
            new ObservableCollection<DataServer>();
        public ObservableCollection<DataServer> ListClients
        {
            get { return listClients; }
            set
            {
                listClients = value;
                OnPropertyChanged();
            }
        }

        public void StartServer()
        {
            ServerMono serverMono = new ServerMono();
            ServerMono.ActionMsg += (msg) =>
            {
                win.Dispatcher.BeginInvoke((ThreadStart)delegate ()
                {
                    Msg = msg;
                });

            };
            ServerMono.ActionData += (msg) =>
            {
                win.Dispatcher.BeginInvoke((ThreadStart)delegate ()
                {
                    //GetDataContext.Data += msg + "\r\n";
                });
            };

            ServerMono.ObservableClient += (obj) =>
            {
                var client = ((ObservableListClients)obj);
                if (client.TypeObservable == "add")
                {
                    win.Dispatcher.BeginInvoke((ThreadStart)delegate ()
                    {
                        if (ListClients != null)
                           ListClients.Add(client.Cleent);
                        //if (GetDataContext.ListClients.Count == 1)
                        //    GetDataContext.Client = GetDataContext.ListClients[0];
                    });
                }
                else if (client.TypeObservable == "delete")
                {
                    win.Dispatcher.BeginInvoke((ThreadStart)delegate ()
                    {
                        if (ListClients != null)
                        {
                            if (ListClients.Contains(client.Cleent))
                                ListClients.Remove(client.Cleent);

                            //if(GetDataContext.Client == null && GetDataContext.ListClients.Count > 0)
                            //    GetDataContext.Client = GetDataContext.ListClients[0];

                            if (ListClients == null || ListClients.Count == 0 && win.CMsg.Visibility == Visibility.Visible)
                                win.CMsg.Visibility = Visibility.Collapsed;
                        }
                    });
                }
            };

            var t = serverMono.CreatedServer();
        }


    }
}
