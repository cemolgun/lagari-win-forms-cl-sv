using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClSv
{
    public partial class TextForm : Form
    {
        UdpClient udp_receive = new UdpClient(Local.port);
        public TextForm()
        {
            InitializeComponent();

            richTextBox1.Text += $"Listening on: {Local.ip}:{Local.port}\nSending to: {ConnectTo.ip}:{ConnectTo.port}";

            this.FormClosing += TextForm_FormClosing;

            udp_receive.BeginReceive(new AsyncCallback(receive), null);
        }

        private void TextForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void receive(IAsyncResult result)
        {
            IPEndPoint listen_to = new IPEndPoint(IPAddress.Any, Local.port);
            byte[] received_bytes = udp_receive.EndReceive(result, ref listen_to);
            string received_str = Encoding.UTF8.GetString(received_bytes);

            this.Invoke(new MethodInvoker(delegate
            {
                richTextBox1.Text += $"\nReceived: {received_str}";
            }));

            udp_receive.BeginReceive(new AsyncCallback(receive), null);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient udp_client = new UdpClient();
            string message = textBox1.Text;
            byte[] message_byte = Encoding.UTF8.GetBytes(message);

            udp_client.Send(message_byte, message_byte.Length, ConnectTo.ip, ConnectTo.port);

            richTextBox1.Text += $"\nSent: {message}";
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
