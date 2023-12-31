﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UdpServer :Setting
    {

        public void runUdp()
        {
            UdpClient udpListener = new UdpClient(UDP_PORT);
            Console.WriteLine("UDP Server started. Waiting for messages...");
            while (true)
            {
                IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, UDP_PORT);
                byte[] buffer = udpListener.Receive(ref clientEndPoint);
                string message = Encoding.ASCII.GetString(buffer);
                Console.WriteLine("UDP Message received: " + message);
            }
        }
    }
}
