using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClSv
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = !(textBox1.Enabled);

            if (!textBox1.Enabled)
            {
                textBox1.Text = Local.ip;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectTo.ip = textBox1.Text;
                ConnectTo.port = Convert.ToInt32(textBox2.Text);
                Local.port = Convert.ToInt32(textBox3.Text);
                Debug.WriteLine($"Con port = {ConnectTo.port}\nLocal port = {Local.port}");
            }
            catch
            {
                textBox2.BackColor = Color.LightPink;
                textBox3.BackColor = Color.LightPink;
                return;
            }

            if (Local.has_appropriate_adress() && ConnectTo.has_appropriate_adress())
            {
                TextForm text_form = new TextForm();
                text_form.Show();
                this.Hide();
            }
            else
                return;

        }
    }
}
