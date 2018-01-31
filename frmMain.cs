using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SocketClient
{
    public partial class frmMain : Form
    {
        Int32 ipPort = 10001;
        private Socket senderSock;
        byte[] bytes = new byte[1024]; 

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnectToServer_Click(object sender, EventArgs e)
        {
            try
            {
                SocketPermission permission = new SocketPermission(
                    NetworkAccess.Connect,
                    TransportType.Tcp,
                    "",
                    SocketPermission.AllPorts
                    );

                permission.Demand();

                IPHostEntry ipHost = Dns.GetHostEntry("");

                IPAddress ipAddr = ipHost.AddressList[0];

                IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, ipPort);

                senderSock = new Socket(
                    ipAddr.AddressFamily,
                    SocketType.Stream,
                    ProtocolType.Tcp
                    );

                senderSock.NoDelay = false;

                senderSock.Connect(ipEndPoint);
                txtServerReply.Text = "Socket Client connected to " + ipEndPoint.Address.MapToIPv4().ToString();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void ClientDisconnect()
        {
            try
            {
                senderSock.Shutdown(SocketShutdown.Both);

                senderSock.Close();

                btnDisconnect.Enabled = false;
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            ClientDisconnect();
        }

        private void btnSendDataToServer_Click(object sender, EventArgs e)
        {
            try
            {               
                string theMessageToSend = txtClientDataToSend.Text;
                byte[] msg = Encoding.Unicode.GetBytes(txtClientDataToSend.Text + "<####>");

                int bytesSend = senderSock.Send(msg);

                ReceiveDataFromServer();
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void ReceiveDataFromServer()
        {
            try
            {
                int bytesRec = senderSock.Receive(bytes);

                String theMessageToReceive = Encoding.Unicode.GetString(bytes, 0, bytesRec);

                while (senderSock.Available > 0)
                {
                    bytesRec = senderSock.Receive(bytes);
                    theMessageToReceive += Encoding.Unicode.GetString(bytes, 0, bytesRec);
                }

                txtServerReply.Text = "Server Response: " + theMessageToReceive;
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.ToString()); 
            }
        }
    }
}
