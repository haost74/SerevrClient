using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TServer.src
{

    public sealed class DataServer
    {
        private string guidStr = Guid.NewGuid().ToString();
        public string GuideStr { get { return guidStr; } }
        // Size of receive buffer.  
        public const int BufferSize = 1024;

        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];

        // Received data string.
        public StringBuilder sb = new StringBuilder();

        // Client socket.
        public Socket workSocket = null;

        public bool IsListen = true;

        public  async Task ReceiveMessage()
        {
            await Task.Run(() =>
            {
                while (IsListen)
                {
                    try
                    {
                        int receiveNumber = workSocket.Receive(buffer);
                        Console.WriteLine($@"{workSocket.RemoteEndPoint.ToString()} {Encoding.ASCII.GetString(buffer, 0, receiveNumber)}");
                        Send(GuideStr);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Server.DeleteClient(workSocket);
                        workSocket.Shutdown(SocketShutdown.Both);
                        workSocket.Close();
                        break;
                    }
                }
            });
        }

        public void Send(string msgStr)
        {
            try
            {
                byte[] msg = Encoding.ASCII.GetBytes(msgStr);
                if (workSocket.Connected)
                {
                    int bytesSent = workSocket.Send(msg);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    public class Server
    {
        private static Socket serverSocket;
        public static List<DataServer> dataServers = new List<DataServer>();
        public async Task CreatedServer(string ipAddress = "192.168.1.132", int port = 7771)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(ipAddress);
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(ip, port));
                serverSocket.Listen(10000);
                Console.WriteLine($"Start server {ipAddress}:{port}");

                await ListenClientConnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }

        public static void DeleteClient(Socket client)
        {
            try
            {
                int id = -1;
                for (int i = 0; i < dataServers.Count; ++i)
                {
                    if (dataServers[i].workSocket.RemoteEndPoint == client.RemoteEndPoint)
                    {
                        id = i;
                        break;
                    }
                }

                if (id != -1)
                    dataServers.RemoveAt(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void DeleteClient()
        {
            try
            {
                List<int> list = new List<int>();
                for (int i = 0; i < dataServers.Count; ++i)
                {
                    if (!dataServers[i].workSocket.Connected)
                        list.Add(i);
                }

                for (int i = 0; i < list.Count; ++i)
                {
                    if (dataServers.Contains(dataServers[list[i]]))
                    {
                        dataServers.RemoveAt(list[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private async Task ListenClientConnect()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        //DeleteClient();
                        DataServer ds = new DataServer();
                        ds.workSocket = serverSocket.Accept();
                        Console.WriteLine($"Client {ds.workSocket.RemoteEndPoint.ToString()} connected {DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}");
                        dataServers.Add(ds);
                        var task = ds.ReceiveMessage();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            });
        }
    }
}
