using System;  
using System.Net;  
using System.Net.Sockets;  
using System.Text;  

class Program   
{  
    static void Main(string[] args)   
    {  
        Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,  
            ProtocolType.Udp);  

        IPAddress broadcast = IPAddress.Parse("192.168.4.1");
        Console.WriteLine("Type a number to move the robot:");
        Console.WriteLine("1 : Forward");
        Console.WriteLine("2 : Backward");
        Console.WriteLine("3 : Left");
        Console.WriteLine("4 : Right");
        Console.WriteLine("5 : Stop");
        Console.WriteLine("");
        while (true)
        {
           
            byte[] sendbuf = Encoding.ASCII.GetBytes(Console.ReadLine());
            IPEndPoint ep = new IPEndPoint(broadcast, 1025);

            s.SendTo(sendbuf, ep);
        }
        Console.WriteLine("Message sent to the broadcast address");  
    }  
} 