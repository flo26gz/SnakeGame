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
        private Thread thListener;
        private Thread thSender;
        private UdpClient listenclient;
        private UdpClient sendClient;
        private Player host;
        private String hostPlayer;
        private IPEndPoint local;
        private IPEndPoint local2;
        private Socket listenSocket;
        private Socket sendSocket;

        private String opponentPlayer;
        public Network(String name)
        {
           
            host = new Player(name);
            hostPlayer = "nothing ";
            opponentPlayer = "nothing";
            //local = new IPEndPoint(IPAddress.Loopback, 6000);
            //local2 = new IPEndPoint(IPAddress.Loopback, 6005);
            //listenclient = new UdpClient();
           // listenclient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
           // sendClient = new UdpClient();
           // sendClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
          
            
        }

        public void createMatch()
        {
            hostPlayer = host.Name + "," + host.Ip;
             listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            listenSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);
            listenSocket.Bind(new IPEndPoint(IPAddress.Any, 50000));
            listenSocket.SetSocketOption(SocketOptionLevel.IP,SocketOptionName.AddMembership, new MulticastOption(IPAddress.Parse("239.1.1.42")));
           // listenclient.Client.Bind(local);           
            thListener = new Thread(new ThreadStart(listen));
            thListener.IsBackground = true;
            thListener.Start();

           // thSender = new Thread(new ThreadStart(sendAnswer));
           // thSender.IsBackground = true;
          //  thSender.Start();

        }

        public void listen()
        {

                byte[] buffer = new byte[1024];
                int count  = listenSocket.Receive(buffer);
                opponentPlayer = Encoding.Default.GetString(buffer,0,count);
                MessageBox.Show(opponentPlayer, opponentPlayer, MessageBoxButtons.YesNo);
               // listenclient.Close();
           
        }


        public void sendAnswer()
        {
 
            sendClient.Client.Bind(local2);
            String message = host.Name + "," + host.Ip;
            Byte[] msg = Encoding.Default.GetBytes(message);
            int res = sendClient.Send(msg, msg.Length,local2);
            MessageBox.Show(host.Ip,""+res, MessageBoxButtons.YesNo);
            sendClient.Close();
           
        }

        public void joinMatch()
        {

          //  listenclient.Client.Bind(local2);
            sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint multicastendpoint = new IPEndPoint(IPAddress.Parse("239.1.1.42"), 50000);
           // thListener = new Thread(new ThreadStart(listen));
            //thListener.IsBackground = true;
            //thListener.Start();

            //sendClient.Client.Bind(local);
            String message = host.Name + "," + host.Ip;
            //Byte[] msg = Encoding.Default.GetBytes(message);
            //int res = sendClient.Send(msg, msg.Length, local);
            sendSocket.SendTo(Encoding.Default.GetBytes(message), message.Length, SocketFlags.None, multicastendpoint);
            
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
