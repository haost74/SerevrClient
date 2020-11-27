using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerSocket.src.Client
{
    public class ClientMono
    {
        static Socket sender = null;
        ~ClientMono()
        {
            if (sender != null)
            {
                if (sender.Connected)
                    sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
        }

        public string Address { get; protected set; }
        public int Port { get; protected set; }

        public ClientMono(string address = "192.168.1.132", int port = 7771)
        {
            Address = address;
            Port = port;
        }

        public void StartClient(string msgStr, Action<string> outRes)
        {
            // Data buffer for incoming data.  
            byte[] bytes = new byte[1024];

            // Connect to a remote device.  
            try
            {
                try
                {
                    // Establish the remote endpoint for the socket.  
                    // This example uses port 11000 on the local computer.  
                    if (sender == null || sender.Connected == false)
                    {
                        IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                        IPAddress ipAddress = IPAddress.Parse(Address);// ipHostInfo.AddressList[1];
                        IPEndPoint remoteEP = new IPEndPoint(ipAddress, Port);

                        // Create a TCP/IP  socket.  

                        sender = new Socket(ipAddress.AddressFamily,
                           SocketType.Stream, ProtocolType.Tcp);

                        // Connect the socket to the remote endpoint. Catch any errors.  

                        sender.Connect(remoteEP);
                    }

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());


                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes(msgStr);

                    // Send the data through the socket.  
                    int bytesSent = sender.Send(msg);

                    // Receive the response from the remote device.  
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("Echoed test = {0}",
                        Encoding.ASCII.GetString(bytes, 0, bytesRec));
                    outRes?.Invoke(Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    // Release the socket.  
                    //sender.Shutdown(SocketShutdown.Both);
                    //sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    throw;
                }
                catch (SocketException se)
                {
                    throw;
                }
                catch (Exception e)
                {
                    throw;
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

    }
}
