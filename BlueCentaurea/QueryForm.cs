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
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        public void SelectTabPages(int index)
        {
            this.tabCtrlQuery.SelectedIndex = index;
            this.Show();
        }

        private void btnQQOnlieCheck_Click(object sender, EventArgs e)
        {
            LoadingControl pLoading = LoadingControl.getLoading();
            pLoading.SetExecuteMethod(testMethod);
            pLoading.ShowDialog();
        }

        private void testMethod()
        {
            LoadingControl pLoading = LoadingControl.getLoading();

            QQOnlineWebService.qqOnlineWebService webService = new QQOnlineWebService.qqOnlineWebService();

            string result = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                pLoading.SetCaptionAndDescription("", "", "");
                result = webService.qqCheckOnline(this.textBoxQQNum.Text);
                System.Threading.Thread.Sleep(1000);
            }
            LoadingControl.getLoading().CloseLoadingForm();
            QQOnlineShow(result);
        }

        private void QQOnlineShow(string result)
        {
            this.textBoxQQOnlineResult.Text = "Y".Equals(result) ? "在线" : "离线";            
        }

        private void QueryForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }
    }
}
