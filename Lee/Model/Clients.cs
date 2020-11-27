using ServerSocket.src.Server;
using System.Collections.Generic;
using System.Net;

namespace Lee.Model
{
    public class Clients
    {
        private static  Clients instance = new Clients();
        static object obj = new object();
        private List<DataServer> dataServers = new List<DataServer>();
        public static Clients GetInstance()
        {
            if(instance == null)
            {
                lock(obj)
                {
                    if (instance == null)
                    {
                        instance = new Clients();
                    }
                }
            }

            return instance;
        }

        public DataServer GetClient(EndPoint RemoteEndPoint)
        {
            if(dataServers != null)
            for (int i = 0; i < dataServers.Count; ++i)
                if (dataServers[i].workSocket.RemoteEndPoint == RemoteEndPoint)
                    return dataServers[i];
            return null;
        }

        public void AddClient(DataServer ds)
        {
            if (dataServers == null) dataServers = new List<DataServer>();
            dataServers.Add(ds);
        }

        public void RemoteClient(DataServer ds)
        {
            if (dataServers != null && dataServers.Contains(ds))
                dataServers.Remove(ds);
        }




    }
}
