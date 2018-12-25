using System;
using System.Windows.Forms;

namespace Corax.Core.Client
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            
        }
        
        private void llClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearMessages();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddMessage(string message)
        {
            txtMessages.Invoke((MethodInvoker)delegate { txtMessages.AppendText(message + Environment.NewLine); });
        }

        private void AddMessage()
        {
            txtMessages.Invoke((MethodInvoker)delegate { txtMessages.AppendText(Environment.NewLine); });
        }
        
        private void ClearMessages()
        {
            txtMessages.Invoke((MethodInvoker)delegate { txtMessages.Text = ""; });
        }
    }
}
