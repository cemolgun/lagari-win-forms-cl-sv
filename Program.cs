using System.Diagnostics;
using System.Net;

namespace WinFormsClSv
{

    class Program
    {
        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ConnectionForm());
        }
    }

    class Local
    {
        public static string ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
        public static int port = 0;

        public static bool has_appropriate_adress()
        {
            Debug.WriteLine("has_appropriate_adress started");
            if (port > 0 && port <= 65535)
            {
                Debug.WriteLine("Port check done");
                if (ip.Length >= 8 && ip.Length <= 16)
                {
                    Debug.WriteLine("len check done");
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
    class ConnectTo
    {
        public static string ip = "";
        public static int port = 0;

        public static bool has_appropriate_adress()
        {
            Debug.WriteLine("has_appropriate_adress started");
            if (port > 0 && port <= 65535)
            {
                Debug.WriteLine("Port check done");
                if (ip.Length >= 8 && ip.Length <= 16)
                {
                    Debug.WriteLine("len check done");
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }

}