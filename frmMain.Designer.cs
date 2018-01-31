namespace SocketClient
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtServerReply = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnSendDataToServer = new System.Windows.Forms.Button();
            this.txtClientDataToSend = new System.Windows.Forms.TextBox();
            this.btnConnectToServer = new System.Windows.Forms.Button();
            this.lblSocketClient = new System.Windows.Forms.Label();
            this.lblOutgoingMessages = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtServerReply
            // 
            this.txtServerReply.Location = new System.Drawing.Point(16, 203);
            this.txtServerReply.Multiline = true;
            this.txtServerReply.Name = "txtServerReply";
            this.txtServerReply.Size = new System.Drawing.Size(369, 51);
            this.txtServerReply.TabIndex = 19;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(178, 46);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(157, 23);
            this.btnDisconnect.TabIndex = 18;
            this.btnDisconnect.Text = "Disconnect From Server";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnSendDataToServer
            // 
            this.btnSendDataToServer.Location = new System.Drawing.Point(278, 99);
            this.btnSendDataToServer.Name = "btnSendDataToServer";
            this.btnSendDataToServer.Size = new System.Drawing.Size(106, 75);
            this.btnSendDataToServer.TabIndex = 17;
            this.btnSendDataToServer.Text = "Send Data";
            this.btnSendDataToServer.UseVisualStyleBackColor = true;
            this.btnSendDataToServer.Click += new System.EventHandler(this.btnSendDataToServer_Click);
            // 
            // txtClientDataToSend
            // 
            this.txtClientDataToSend.Location = new System.Drawing.Point(16, 99);
            this.txtClientDataToSend.Multiline = true;
            this.txtClientDataToSend.Name = "txtClientDataToSend";
            this.txtClientDataToSend.Size = new System.Drawing.Size(256, 75);
            this.txtClientDataToSend.TabIndex = 16;
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Location = new System.Drawing.Point(16, 45);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(143, 23);
            this.btnConnectToServer.TabIndex = 15;
            this.btnConnectToServer.Text = "Connect To Server";
            this.btnConnectToServer.UseVisualStyleBackColor = true;
            this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
            // 
            // lblSocketClient
            // 
            this.lblSocketClient.AutoSize = true;
            this.lblSocketClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocketClient.Location = new System.Drawing.Point(12, 9);
            this.lblSocketClient.Name = "lblSocketClient";
            this.lblSocketClient.Size = new System.Drawing.Size(132, 24);
            this.lblSocketClient.TabIndex = 14;
            this.lblSocketClient.Text = "Socket Client";
            // 
            // lblOutgoingMessages
            // 
            this.lblOutgoingMessages.AutoSize = true;
            this.lblOutgoingMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutgoingMessages.Location = new System.Drawing.Point(13, 83);
            this.lblOutgoingMessages.Name = "lblOutgoingMessages";
            this.lblOutgoingMessages.Size = new System.Drawing.Size(89, 13);
            this.lblOutgoingMessages.TabIndex = 20;
            this.lblOutgoingMessages.Text = "Outgoing Data";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(13, 187);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(49, 13);
            this.lblActivity.TabIndex = 21;
            this.lblActivity.Text = "Activity";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 268);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblOutgoingMessages);
            this.Controls.Add(this.txtServerReply);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnSendDataToServer);
            this.Controls.Add(this.txtClientDataToSend);
            this.Controls.Add(this.btnConnectToServer);
            this.Controls.Add(this.lblSocketClient);
            this.Name = "frmMain";
            this.Text = "Socket Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerReply;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnSendDataToServer;
        private System.Windows.Forms.TextBox txtClientDataToSend;
        private System.Windows.Forms.Button btnConnectToServer;
        private System.Windows.Forms.Label lblSocketClient;
        private System.Windows.Forms.Label lblOutgoingMessages;
        private System.Windows.Forms.Label lblActivity;
    }
}

