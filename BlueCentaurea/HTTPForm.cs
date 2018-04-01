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
using System.IO;

namespace BlueCentaurea
{
    public partial class HTTPForm : Form
    {
        public static HTTPForm httpForm;
        public HTTPForm()
        {
            InitializeComponent();
            httpForm = this;

        }

        private void btnSend1_Click(object sender, EventArgs e)
        {

        }

        private void buttonServerStart_Click(object sender, EventArgs e)
        {
            HttpListener listener = new HttpListener();
            listener.AuthenticationSchemes = AuthenticationSchemes.Anonymous;
            listener.Prefixes.Add(this.richTextBoxServerAddress.Text);
            listener.Start();
            this.richTextBoxServerRecv.Text = "WEB服务器启动...";
            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                context.Response.StatusCode = 200;
                this.richTextBoxServerRecv.Text = context.Request.RawUrl;
                StreamWriter writer = new StreamWriter(context.Response.OutputStream);
                writer.WriteLine(this.richTextBoxServerSend.Text);
            }
        }
    }
}
