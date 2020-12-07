using ServerSocket.src.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lee.Controls
{
    public class MsgClientModel : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        #endregion

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

        public void Init(DataServer ds)
        {
            CustomerName = ds.workSocket.RemoteEndPoint.ToString();
            Client = ds;
        }

        private string customerName = "";
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if(!string.IsNullOrEmpty(value))
                customerName = $"selected client {value}".ToUpper();
                OnPropertyChanged();
            }
        }

        private string msgToServer = "";
        public string MsgToServer
        {
            get { return msgToServer; }
            set
            {
                msgToServer = value;
                OnPropertyChanged();
            }
        }
    }
}
