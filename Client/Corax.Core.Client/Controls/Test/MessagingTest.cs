using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corax.Core.Client.Controls.Test
{
    public partial class MessagingTest : UserControlBase
    {
        public MessagingTest()
        {
            InitializeComponent();
        }

        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            AddMessage(txtMessages.Text);
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            AddLine();
        }

        private void btnAddLines_Click(object sender, EventArgs e)
        {
            int lineCount;
            if(Int32.TryParse(txtLineCount.Text, out lineCount))
            {
                AddLines(lineCount);
            }
        }

        private void btnClearMessages_Click(object sender, EventArgs e)
        {
            ClearMessages();
        }
    }
}
