using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows;

namespace Tumbledryer_2D
{
    public partial class Tumbledryer_2D : Form
    {
        public Tumbledryer_2D()
        {
            InitializeComponent();

            //Scan for COM ports in use
            String[] Ports = SerialPort.GetPortNames();
            if (Ports.Length != 0)
            {
                cmbbx_COMport.Items.AddRange(Ports);
                cmbbx_COMport.SelectedIndex = 0;
            }
        }

        Color Default = Color.FromArgb(0,0,0,0);

        private void rdbtn_ThisMachine_CheckedChanged(object sender, EventArgs e)
        {
            lbl_usingIP.Text = "Using IP:";
            txtbx_IP.Text = "127.0.0.1";
            lbl_usingIP.Enabled = false;
            txtbx_IP.Enabled = false;
        }
        private void rdbtn_OtherMachine_CheckedChanged(object sender, EventArgs e)
        {
            lbl_usingIP.Text = "Enter IP here:";
            txtbx_IP.Clear();
            lbl_usingIP.Enabled = true;
            txtbx_IP.Enabled = true;
        }
        
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            String[] PortOptions = SerialPort.GetPortNames();

            cmbbx_COMport.Items.Clear();
            cmbbx_COMport.Items.AddRange(PortOptions);
        }
        private void btnStartStopServer_Click(object sender, EventArgs e)
        {
            try
            {
                StartStopServer();
            }
            catch (Exception ex)
            {
                txtbx_Status.AppendText(ex.Message);
            }
            
        }
        private void UpdateServerStatus_Tick(object sender, EventArgs e)
        {
            switch (serverstatus)
            {
                case ServerStatus.offline:
                    btnStartStopServer.BackColor = Default;
                    btnStartStopServer.Text = "--> Click to start Server <--";
                    break;
                case ServerStatus.starting:
                    btnStartStopServer.BackColor = Color.LightBlue;
                    btnStartStopServer.Text = "Server starting";
                    break;
                case ServerStatus.listening:
                    btnStartStopServer.BackColor = Color.LightYellow;
                    btnStartStopServer.Text = "Server listening";
                    break;
                case ServerStatus.connected:
                    btnStartStopServer.BackColor = Color.LightGreen;
                    btnStartStopServer.Text = "DCS Connected :-)";
                    break;
                case ServerStatus.reading:
                    btnStartStopServer.BackColor = Color.Green;
                    btnStartStopServer.Text = "- - READING DATA - -";
                    break;
                case ServerStatus.shutting_down:
                    btnStartStopServer.BackColor = Color.PaleVioletRed;
                    btnStartStopServer.Text = "Shutting down Server";
                    break;
                default:
                    break;
            }
        }
    }
}
