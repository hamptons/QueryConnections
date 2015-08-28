namespace QueryServerConnections
{
    partial class activeConnectionUserControl
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
            this.activeConnectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // activeConnectionLabel
            // 
            this.activeConnectionLabel.BackColor = System.Drawing.Color.Silver;
            this.activeConnectionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeConnectionLabel.Location = new System.Drawing.Point(0, 0);
            this.activeConnectionLabel.Name = "activeConnectionLabel";
            this.activeConnectionLabel.Size = new System.Drawing.Size(540, 40);
            this.activeConnectionLabel.TabIndex = 0;
            this.activeConnectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activeConnectionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.activeConnectionLabel);
            this.Name = "activeConnectionUserControl";
            this.Size = new System.Drawing.Size(540, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label activeConnectionLabel;
    }
}
