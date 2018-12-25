namespace Corax.Core.Client.Controls.Test
{
    partial class MessagingTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.btnAddMessage = new System.Windows.Forms.Button();
            this.btnClearMessages = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.btnAddLines = new System.Windows.Forms.Button();
            this.txtLineCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(61, 13);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(378, 52);
            this.txtMessages.TabIndex = 1;
            this.txtMessages.Text = "Test Message";
            // 
            // btnAddMessage
            // 
            this.btnAddMessage.Location = new System.Drawing.Point(445, 13);
            this.btnAddMessage.Name = "btnAddMessage";
            this.btnAddMessage.Size = new System.Drawing.Size(128, 23);
            this.btnAddMessage.TabIndex = 2;
            this.btnAddMessage.Text = "Add Message";
            this.btnAddMessage.UseVisualStyleBackColor = true;
            this.btnAddMessage.Click += new System.EventHandler(this.btnAddMessage_Click);
            // 
            // btnClearMessages
            // 
            this.btnClearMessages.Location = new System.Drawing.Point(445, 42);
            this.btnClearMessages.Name = "btnClearMessages";
            this.btnClearMessages.Size = new System.Drawing.Size(128, 23);
            this.btnClearMessages.TabIndex = 3;
            this.btnClearMessages.Text = "Clear Messages";
            this.btnClearMessages.UseVisualStyleBackColor = true;
            this.btnClearMessages.Click += new System.EventHandler(this.btnClearMessages_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(445, 100);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(128, 23);
            this.btnAddLine.TabIndex = 4;
            this.btnAddLine.Text = "Add Line";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // btnAddLines
            // 
            this.btnAddLines.Location = new System.Drawing.Point(445, 71);
            this.btnAddLines.Name = "btnAddLines";
            this.btnAddLines.Size = new System.Drawing.Size(128, 23);
            this.btnAddLines.TabIndex = 5;
            this.btnAddLines.Text = "Add Lines";
            this.btnAddLines.UseVisualStyleBackColor = true;
            this.btnAddLines.Click += new System.EventHandler(this.btnAddLines_Click);
            // 
            // txtLineCount
            // 
            this.txtLineCount.Location = new System.Drawing.Point(413, 73);
            this.txtLineCount.Name = "txtLineCount";
            this.txtLineCount.Size = new System.Drawing.Size(26, 20);
            this.txtLineCount.TabIndex = 7;
            this.txtLineCount.Text = "3";
            // 
            // MessagingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLineCount);
            this.Controls.Add(this.btnAddLines);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.btnClearMessages);
            this.Controls.Add(this.btnAddMessage);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.label1);
            this.Name = "MessagingTest";
            this.Size = new System.Drawing.Size(650, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Button btnAddMessage;
        private System.Windows.Forms.Button btnClearMessages;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.Button btnAddLines;
        private System.Windows.Forms.TextBox txtLineCount;
    }
}
