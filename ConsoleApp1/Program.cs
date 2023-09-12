using System;
using System.Collections.Generic;

using ConsoleApp1;
class Program
{

    static void Main(string[] args)

    {
        var client = new Client();
        Console.WriteLine("1-start Tcp Server");
        Console.WriteLine("2-start Udp Server");
        Console.WriteLine("3-Send Tcp Server");
        Console.WriteLine("4-send Udp Server");


        string input;
        Console.Write(" Input: ");
        input = Console.ReadLine();
        int s = Convert.ToInt32(input);
        Console.WriteLine("Your input: {0}", s);


        if (s == 1)
        {
            var tcpserver = new TcpServer();
            tcpserver.runTcp();
        }


        if (s == 2)
        {
            var udpserver = new UdpServer();
            udpserver.runUdp();
        }

        if (s == 3)
        {
            while (true)
            {
                Console.Write("Enter Message: ");
                string message= Console.ReadLine();


                client.SendTcpMessage(message);
            }
        }

        if (s  == 4)


        {
            while (true)
            {
                Console.Write("Enter Message: ");
                string message = Console.ReadLine();

                client.SendUdpMessage(message);
            }
        }
    }
}