using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueCentaurea
{
    public partial class NetworkForm : Form
    {
        private int netConnectStatusIndex = 1;  // 网络连接标志

        public NetworkForm()
        {
            InitializeComponent();
        }

        private void btnSendClr_Click(object sender, EventArgs e)
        {
            textSendRegion.Text = String.Empty;
        }

        private void btnRecvClr_Click(object sender, EventArgs e)
        {
            textRecvRegion.Text = String.Empty;
        }

        private void rabtnClient_CheckedChanged(object sender, EventArgs e)
        {
            lblMultiFunc.Text = "远程主机地址";
        }

        private void rabtnServer_CheckedChanged(object sender, EventArgs e)
        {
            lblMultiFunc.Text = "本地主机端口";
        }

        private void textLocalhost_MouseDown(object sender, MouseEventArgs e)
        {
            textLocalhost.Text = String.Empty;
        }

        private void textMultiFunc_MouseDown(object sender, MouseEventArgs e)
        {
            textMultiFunc.Text = String.Empty;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            switch(netConnectStatusIndex)
            {
                case 0:
                    {
                        netConnectStatusIndex = 1;
                        Image image = BlueCentaurea.Properties.Resources.LightOff1;
                        this.lblConnectStatus.Image = image.Clone() as Image;
                        image.Dispose();
                        btnConnect.Text = "连接";
                        break;
                    }
                case 1:
                    {
                        netConnectStatusIndex = 0;
                        Image image = BlueCentaurea.Properties.Resources.LightOn;
                        this.lblConnectStatus.Image = image.Clone() as Image;
                        image.Dispose();
                        btnConnect.Text = "断开";
                        break;
                    }
                default:
                    netConnectStatusIndex = 0;
                    break;
            }
        }
    }
}
