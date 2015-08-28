namespace QueryServerConnections
{
    partial class activeConnectionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activeConnectionsForm));
            this.connectionsListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.serverListPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.serverListPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionsListFlowLayoutPanel
            // 
            this.connectionsListFlowLayoutPanel.AutoScroll = true;
            this.connectionsListFlowLayoutPanel.Location = new System.Drawing.Point(3, 2);
            this.connectionsListFlowLayoutPanel.Name = "connectionsListFlowLayoutPanel";
            this.connectionsListFlowLayoutPanel.Size = new System.Drawing.Size(547, 216);
            this.connectionsListFlowLayoutPanel.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(205, 224);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(140, 32);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // serverListPictureBox
            // 
            this.serverListPictureBox.Image = global::QueryServerConnections.Properties.Resources.Sitemap;
            this.serverListPictureBox.Location = new System.Drawing.Point(518, 224);
            this.serverListPictureBox.Name = "serverListPictureBox";
            this.serverListPictureBox.Size = new System.Drawing.Size(32, 32);
            this.serverListPictureBox.TabIndex = 2;
            this.serverListPictureBox.TabStop = false;
            this.serverListPictureBox.Click += new System.EventHandler(this.serverListPictureBox_Click);
            // 
            // activeConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.serverListPictureBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.connectionsListFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "activeConnectionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Connections";
            this.Load += new System.EventHandler(this.activeConnectionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serverListPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel connectionsListFlowLayoutPanel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.PictureBox serverListPictureBox;
    }
}

