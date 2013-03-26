using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Snake
{
    class Player
    {
        private String name;
        private String ip;

        public Player(String name)
        {
            this.name = name;
            this.ip = getIpComputer();
            
        }

        public String Ip
        {
            get { return ip; }
            set { ip = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String getIpComputer()
        {
            string ip = "";
            IPAddress[] addr = Dns.GetHostAddresses(Dns.GetHostName());
            ip = addr[2].ToString();

            return ip;
        }

    }
}
