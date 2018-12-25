namespace Corax.Core.Client.Controls
{
    partial class TripControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartTrip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartTrip
            // 
            this.btnStartTrip.Location = new System.Drawing.Point(12, 13);
            this.btnStartTrip.Name = "btnStartTrip";
            this.btnStartTrip.Size = new System.Drawing.Size(75, 23);
            this.btnStartTrip.TabIndex = 0;
            this.btnStartTrip.Text = "Start Trip";
            this.btnStartTrip.UseVisualStyleBackColor = true;
            this.btnStartTrip.Click += new System.EventHandler(this.btnStartTrip_Click);
            // 
            // TripControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.btnStartTrip);
            this.Name = "TripControl";
            this.Size = new System.Drawing.Size(650, 650);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartTrip;
    }
}
