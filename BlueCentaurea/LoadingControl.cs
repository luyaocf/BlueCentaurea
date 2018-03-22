using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BlueCentaurea
{
    public partial class LoadingControl : Form
    {

        public delegate void mydelegate();
        public mydelegate eventMethod;
        private static LoadingControl pLoading = new LoadingControl();
        delegate void SetTextCallback(string title,string caption,string description);
        delegate void CloseFormCallback();
        public LoadingControl()
        {
            InitializeComponent();
            initLoadintForm();
            Thread t = new Thread(new ThreadStart(delegateEventMethod));
            t.IsBackground = true;
            t.Start();
        }

        private void LoadingControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.IsDisposed)
            {
                this.Dispose(true);
            }
        }

        private void initLoadintForm() {
            this.ControlBox = false;   // 设置不出现关闭按钮
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void delegateEventMethod()
        {
            eventMethod();
        }

        public static LoadingControl getLoading()
        {
            if (pLoading.IsDisposed)
            {
                pLoading = new LoadingControl();
                return pLoading;
            }
            else
            {
                return pLoading;
            }
        }

        //这种方法演示如何在线程安全的模式下调用Windows窗体上的控件。  
        /// <summary>
        /// 设置Loading 窗体的 标题title,标签 caption 和描述 description
        /// </summary>
        /// <param name="title">窗口的标题[为空时，取默认值]</param>
        /// <param name="caption">标签（例如:please wait）[为空时，取默认值]</param>
        /// <param name="description">描述(例如：正在加载资源...)[为空时，取默认值]</param>
        public void SetCaptionAndDescription(string title,string caption, string description)
        {
            if (this.InvokeRequired && this.lbl_caption.InvokeRequired && this.lbl_description.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetCaptionAndDescription);
                this.Invoke(d, new object[] { title,caption, description });
            }
            else
            {
                if (!title.Equals("")) {
                    this.Text = title;
                }
                if (!caption.Equals(""))
                {
                    this.lbl_caption.Text = caption;
                }
                if (!description.Equals("")) {
                    this.lbl_description.Text = description;
                }
            }
        }

        public  void CloseLoadingForm()
        {
            if (this.InvokeRequired)
            {
                CloseFormCallback d = new CloseFormCallback(CloseLoadingForm);
                this.Invoke(d, new object[] {  });
            }
            else
            {
                if (!this.IsDisposed)
                {
                    this.Dispose(true);
                }
            }
        }

        public void SetExecuteMethod(mydelegate method)
        {
              this.eventMethod += method;
        }


    }
}
