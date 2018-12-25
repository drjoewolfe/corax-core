using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corax.Core.Client.Classes;

namespace Corax.Core.Client.Controls
{
    public partial class MessagesControl : UserControlBase, IMessageSink
    {
        public MessagesControl()
        {
            InitializeComponent();
            RegisterMessageSink(this);
        }

        private void llClear_LinkClicked(object sender, EventArgs e)
        {
            ClearMessages();
        }

        public new void AddMessage(string message)
        {
            txtMessages.Invoke((MethodInvoker)delegate { txtMessages.AppendText(message + Environment.NewLine); });
        }

        public new void AddLine()
        {
            txtMessages.Invoke((MethodInvoker)delegate { txtMessages.AppendText(Environment.NewLine); });
        }

        public new void AddLines(int lineCount)
        {
            for (int i = 0; i < lineCount; i++)
            {
                AddLine();
            }
        }

        public new void ClearMessages()
        {
            txtMessages.Invoke((MethodInvoker)delegate { txtMessages.Text = ""; });
        }
    }
}
