using System;

namespace Corax.Core.Client.Controls
{
    public partial class TripControl : UserControlBase
    {
        public TripControl()
        {
            InitializeComponent();
        }

        private void btnStartTrip_Click(object sender, EventArgs e)
        {
            AddMessage("Trip Started.");
        }
    }
}
