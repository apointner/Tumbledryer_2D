using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Tumbledryer_2D
{
    public enum ServerStatus
    {
        offline,
        starting,
        listening,
        connected,
        reading,
        shutting_down
    }

    public partial class Tumbledryer_2D : Form
    {
        public static bool ServerON = false;
        public static ServerStatus serverstatus = ServerStatus.offline;
        private string IP;
        private int Port = 31090;
        Thread t;

        public void StartStopServer()
        {
            if (ServerON)
            {
                ServerON = false;       //Thread will end itself
            }
            else
            {
                if (txtbx_IP.Text == string.Empty)
                {
                    txtbx_Status.AppendText("PLEASE ENTER IP! \r\n");
                    return;
                }
                ServerON = true;
                
                t = new Thread(RunServerRun);
                t.Start();
            }
        }
        void RunServerRun()
        {
            IP = txtbx_IP.Text;
            TcpListener listener = new TcpListener(IPAddress.Parse(IP), Port);

            try
            {
                listener.Start();
                
                serverstatus = ServerStatus.starting;
                Thread.Sleep(400);

                while (ServerON)
                {
                    serverstatus = ServerStatus.listening;
                    while (!listener.Pending() && ServerON)
                    {
                        Thread.Sleep(100);
                    }

                    if (!ServerON) break;

                    TcpClient client = listener.AcceptTcpClient();
                    serverstatus = ServerStatus.connected;

                    StreamReader reader = new StreamReader(client.GetStream());
                    StreamWriter writer = new StreamWriter(client.GetStream());

                    string s = string.Empty;

                    while (ServerON)
                    {
                        s = reader.ReadLine();
                        serverstatus = ServerStatus.reading;

                        if (s == "exit")
                        {
                            break;
                        }

                        //clear the airlock
                        while (Airlock.TryTake(out string os))
                        {
                            //do nothing
                        }
                        //Now we can add the datastring
                        Airlock.TryAdd(s);
                    }
                    reader.Close();
                    writer.Close();
                    client.Close();
                }

                listener.Stop();

                serverstatus = ServerStatus.shutting_down;
                Thread.Sleep(1000);

                serverstatus = ServerStatus.offline;

            }
            catch (Exception ex)
            {
                listener.Stop();
                serverstatus = ServerStatus.shutting_down;
                Thread.Sleep(500);
            }
        }



    }
}
