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

            listenSocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            listenSocketClient.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);
            listenSocketClient.Bind(new IPEndPoint(IPAddress.Any, 51000));
            listenSocketClient.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(IPAddress.Parse("239.1.1.42")));   
            
        }

        public void createMatch()
        {
            hostPlayer = host.Name + "," + host.Ip;

            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 5000);
            //listenSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);
            listenSocket.Bind(ipep);

            IPAddress ip = IPAddress.Parse("224.5.6.7");
            listenSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ip, IPAddress.Any));

            //listenSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(IPAddress.Parse("239.1.1.42")));
            thListener = new Thread(new ThreadStart(listen));
            thListener.IsBackground = true;
            thListener.Start();

            /*sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint multicastendpoint = new IPEndPoint(IPAddress.Parse("239.1.1.42"), 51000);
            String message = host.Name + "," + host.Ip;
            sendSocket.SendTo(Encoding.Default.GetBytes(message), message.Length, SocketFlags.None, multicastendpoint);
            sendSocket.Close();*/
        }

        public void listen()
        {
           
                byte[] buffer = new byte[1024];
                int count  = listenSocket.Receive(buffer);
                opponentPlayer = Encoding.Default.GetString(buffer,0,count);
                Console.WriteLine(opponentPlayer);
              //  MessageBox.Show(opponentPlayer, opponentPlayer, MessageBoxButtons.YesNo);
              //  listenSocket.Close();
           
        }
        /*
        public void listen2()
        {
           
            byte[] buffer = new byte[1024];
            int count = listenSocketClient.Receive(buffer);
            Console.WriteLine("test");       
            opponentPlayer = Encoding.Default.GetString(buffer, 0, count);
            MessageBox.Show("Hello " + opponentPlayer,"hi" + opponentPlayer, MessageBoxButtons.YesNo);
            listenSocketClient.Close();

        }
        */
        public void joinMatch()
        {
            IPAddress ip;
			try 
			{
				
				ip=IPAddress.Parse("224.5.6.7");
				
				sendSocket=new Socket(AddressFamily.InterNetwork, 
								SocketType.Dgram, ProtocolType.Udp);
				
				sendSocket.SetSocketOption(SocketOptionLevel.IP, 
					SocketOptionName.AddMembership, new MulticastOption(ip));

				sendSocket.SetSocketOption(SocketOptionLevel.IP, 
					SocketOptionName.MulticastTimeToLive, 1);
			String message = host.Name + "," + host.Ip;

				IPEndPoint ipep=new IPEndPoint(IPAddress.Parse("224.5.6.7"),5000);
				
				Console.WriteLine("Connecting...");

				sendSocket.Connect(ipep);
               
					sendSocket.Send(Encoding.Default.GetBytes(message),message.Length,SocketFlags.None);
    

				Console.WriteLine("Closing Connection...");
				sendSocket.Close();
			} 
			catch(System.Exception e) { Console.Error.WriteLine(e.Message); }
		
        }
        /*
            sendSocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint multicastendpoint = new IPEndPoint(IPAddress.Parse("239.1.1.42"), 50000);
            String message = host.Name + "," + host.Ip;
            sendSocketClient.SendTo(Encoding.Default.GetBytes(message), message.Length, SocketFlags.None, multicastendpoint);
           // sendSocketClient.Close();
         * */
            /*
            thListener = new Thread(new ThreadStart(listen2));
            thListener.IsBackground = true;
            thListener.Start();
            */

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
