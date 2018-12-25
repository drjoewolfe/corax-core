using Corax.Core.Client.Controls;
using Corax.Core.Client.Controls.Test;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Corax.Core.Client
{
    public partial class Start : Form
    {
        Dictionary<Type, UserControlBase> loadedControls;

        public Start()
        {
            InitializeComponent();
            loadedControls = new Dictionary<Type, UserControlBase>();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            
        }

        private void loadControl(Type controlType)
        {
            if (!controlType.IsSubclassOf(typeof(UserControlBase)))
            {
                return;
            }

            if (loadedControls.ContainsKey(controlType))
            {
                var control = loadedControls[controlType];
                showControl(control);
            }
            else
            {
                var control = Activator.CreateInstance(controlType) as UserControlBase;
                loadedControls.Add(controlType, control);
                showControl(control);
            }
        }

        private void showControl(UserControlBase control)
        {
            pnlViewPort.Controls.Clear();
            pnlViewPort.Controls.Add(control);
        }

        #region Menu Strip

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void standardTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadControl(typeof(TripControl));
        }

        private void messagingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadControl(typeof(MessagingTest));
        }

        #endregion
    }
}
