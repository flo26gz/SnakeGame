using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Windows.Forms;

namespace Snake
{
    class Network
    {
        private Thread  thListener;
        private Player host;
        private String hostPlayer;
        private Socket listenSocket;
        private Socket listenSocketClient;
        private Socket sendSocketClient;
        private Socket sendSocket;
        private String opponentPlayer;

        public Network(String name)
        {
           
            host = new Player(name);
            hostPlayer = "nothing ";
            opponentPlayer = "nothing";

            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            listenSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);
            listenSocket.Bind(new IPEndPoint(IPAddress.Any, 50000));
            listenSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(IPAddress.Parse("239.1.1.42")));

            listenSocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            listenSocketClient.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);
            listenSocketClient.Bind(new IPEndPoint(IPAddress.Any, 51000));
            listenSocketClient.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(IPAddress.Parse("239.1.1.42")));   
            
        }

        public void createMatch()
        {
            hostPlayer = host.Name + "," + host.Ip;
              
           
            thListener = new Thread(new ThreadStart(listen));
            thListener.IsBackground = true;
            thListener.Start();

            sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint multicastendpoint = new IPEndPoint(IPAddress.Parse("239.1.1.42"), 51000);
            String message = host.Name + "," + host.Ip;
            sendSocket.SendTo(Encoding.Default.GetBytes(message), message.Length, SocketFlags.None, multicastendpoint);
            sendSocket.Close();
        }

        public void listen()
        {
            Console.WriteLine("testdjshhds");
                byte[] buffer = new byte[1024];
                int count  = listenSocket.Receive(buffer);
                opponentPlayer = Encoding.Default.GetString(buffer,0,count);
                MessageBox.Show(opponentPlayer, opponentPlayer, MessageBoxButtons.YesNo);
                listenSocket.Close();
           
        }

        public void listen2()
        {
           
            byte[] buffer = new byte[1024];
            int count = listenSocketClient.Receive(buffer);
            Console.WriteLine("test");       
            opponentPlayer = Encoding.Default.GetString(buffer, 0, count);
            MessageBox.Show("Hello " + opponentPlayer,"hi" + opponentPlayer, MessageBoxButtons.YesNo);
            listenSocketClient.Close();

        }

        public void joinMatch()
        {

            sendSocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint multicastendpoint = new IPEndPoint(IPAddress.Parse("239.1.1.42"), 50000);
            String message = host.Name + "," + host.Ip;
            sendSocketClient.SendTo(Encoding.Default.GetBytes(message), message.Length, SocketFlags.None, multicastendpoint);
            sendSocketClient.Close();

            thListener = new Thread(new ThreadStart(listen2));
            thListener.IsBackground = true;
            thListener.Start();
            
        }

        public String HostPlayer
        {
            get { return hostPlayer; }
            set { hostPlayer = value; }
        }

        public String OpponentPlayer
        {
            get { return opponentPlayer; }
            set { opponentPlayer = value; }
        }

    }
}
