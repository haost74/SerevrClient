using ServerSocket.src.Client;
using ServerSocket.src.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ClietTest.Model
{
    public class ClientModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        #endregion

        private ClientMono clientm = null;
        public ClientMono ClientM
        {
            get { return clientm; }
            set
            {
                clientm = value;
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

        private string address = "192.168.1.132";
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged();
            }
        }

        private int port = 7771;
        public int Port
        {
            get { return port; }
            set
            {
                port = value;
                OnPropertyChanged();
            }
        }
    }
}
