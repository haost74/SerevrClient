using ServerSocket.src.Server;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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
    }
}
