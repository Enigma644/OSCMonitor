using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpOSC;
using System.Net;
using System.Net.Sockets;

namespace OSCMonitor
{
    public partial class OSCMonitor : Form
    {
        List<String> messages;
        Dictionary<String, String> messageDict;
        UDPListener listener;
        int maxMessages = 30;
        int singleMessageHeight;
        Boolean stream = false;
        int port = 5000;

        public OSCMonitor()
        {
            InitializeComponent();
            messages = new List<String> { };
            messageDict = new Dictionary<string, string> { };
            singleMessageHeight = messageLabel.Height;
            maxMessages = (int)(buttonMetrics.Height / singleMessageHeight);
        }

        private void OSCMonitor_Load(object sender, EventArgs e)
        {
            clearMessages();
            // The cabllback function
            HandleOscPacket callback = delegate (OscPacket packet)
            {
                var messageReceived = (OscBundle)packet;
                OscBundle bundle = (OscBundle)packet;
                DateTime dt = SharpOSC.Utils.TimetagToDateTime(bundle.Timetag);
                foreach (OscMessage message in bundle.Messages)
                {
                    String text;
                    if (checkBoxUTC.Checked)
                    {
                        text = dt.ToString("yyyy-MM-dd HH:mm:ss.fff tt")+" UTC";
                    }
                    else
                    {
                        text = dt.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss.fff tt")+" Local";
                    }
                    text += " " + message.Address;
                    if (message.Arguments.Count > 0)
                    {
                        text += " [" + message.Arguments.First().ToString() + "]";
                    }
                    if (message.Arguments.Count > 1)
                    {
                        foreach (object obj in message.Arguments.Skip(1))
                        {
                            text += ", [" + obj.ToString() + "]";
                        }
                    }

                    if (stream)
                    {
                        messages.Add(text);
                    } else
                    {
                        if (messageDict.ContainsKey(message.Address))
                        {
                            messageDict[message.Address] = text;
                        } else
                        {
                            messageDict.Add(message.Address, text);
                        }
                    }
                }
                
                updateMessageBox();
            };
            listener = new UDPListener(5000, callback);
        }

        private void updateMessageBox()
        {
            String messageBoxText = "";
            if (stream)
            {
                while (messages.Count > maxMessages)
                {
                    messages.RemoveAt(0);
                }
                if (messages.Count > 0)
                {
                    messageBoxText = messages.First() + "\r\n";
                }
                if (messages.Count > 1)
                {
                    messageBoxText += string.Join("\r\n", messages.Skip(1));
                }
            } else
            {
                foreach(String key in messageDict.Keys)
                {
                    messageBoxText += messageDict[key] + "\r\n";
                }
            }
            SetText(messageBoxText);
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            try
            {
                // InvokeRequired required compares the thread ID of the
                // calling thread to the thread ID of the creating thread.
                // If these threads are different, it returns true.
                if (this.messageLabel.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.messageLabel.Text = text;
                }
            }
            catch (Exception)
            {
                //Ignore exception when closing
            }
        }

        private void OSCMonitor_Resize(object sender, EventArgs e)
        {
            maxMessages = (int)( buttonMetrics.Height / singleMessageHeight);
        }

        private void radioButtonLast_CheckedChanged(object sender, EventArgs e)
        {
            stream = false;
            clearMessages();
        }

        private void radioButtonStream_CheckedChanged(object sender, EventArgs e)
        {
            stream = true;
            clearMessages();
        }

        private void clearMessages()
        {
            messages = new List<String> { };
            messageDict = new Dictionary<string, string> { };
            string initMessage = @"Listening on Port " + port.ToString() + " UDP";
            
            List<string> ips = GetLocalIPAddress();
            foreach (string ip in ips)
            {
                initMessage += "\nIP: "+ip;
            }
            SetText(initMessage);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        public static List<string> GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            List<string> ips = new List<string>();
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ips.Add(ip.ToString());
                }
            }
            return ips;
        }
    }
}
