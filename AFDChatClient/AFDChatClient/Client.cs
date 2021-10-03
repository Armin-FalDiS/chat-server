using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace AFDChatClient
{
    public static class Client
    {
        static Socket socket;
        static byte[] buffer = new byte[1024];
        public static Action<string> updateUserlist = null;
        public static Action<string> updateChatbox = null;

        public static bool Login(string server, string nickname)
        {
            socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect(server, 1375);
                socket.Send(Encoding.ASCII.GetBytes("$" + nickname));
                Console.WriteLine("Socket created to {0}", server);
                (new Thread(recvHandle)).Start();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public static void fetchUserList()
        {
            socket.Send(Encoding.UTF8.GetBytes("_userlist"));
        }

        public static void sendIM(string to, string message)
        {
            socket.Send(Encoding.UTF8.GetBytes("@" + to + ":" + message));
        }

        private static void recvHandle()
        {
            while (true)
            {
                try
                {
                    string data = null;
                    int b = socket.Receive(buffer);
                    data += Encoding.UTF8.GetString(buffer, 0, b);
                    Console.WriteLine("Recieved: " + data);
                    if (data[0] == '#') // update user list
                    {
                        data = data.Remove(0, 1);
                        updateUserlist?.Invoke(data);
                    }
                    else if (data[0] == '@') // instant message
                    {
                        data = data.Remove(0, 1);
                        updateChatbox?.Invoke(data);
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
