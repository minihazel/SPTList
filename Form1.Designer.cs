namespace SPTList
{
    partial class mainForm
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
            this.boxServerPlaceholder = new System.Windows.Forms.Label();
            this.boxPathBox = new System.Windows.Forms.GroupBox();
            this.boxPath = new System.Windows.Forms.TextBox();
            this.boxServers = new System.Windows.Forms.Panel();
            this.boxServersSeparator = new System.Windows.Forms.Panel();
            this.boxServersTitle = new System.Windows.Forms.Label();
            this.boxSelectedServer = new System.Windows.Forms.Panel();
            this.boxSelectedServerSeparator = new System.Windows.Forms.Panel();
            this.boxSelectedServerTitle = new System.Windows.Forms.Label();
            this.boxSelectedServerPlaceholder = new System.Windows.Forms.Label();
            this.boxServersOpenIn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bResetApp = new System.Windows.Forms.Label();
            this.boxPathBox.SuspendLayout();
            this.boxServers.SuspendLayout();
            this.boxSelectedServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxServerPlaceholder
            // 
            this.boxServerPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxServerPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.boxServerPlaceholder.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.boxServerPlaceholder.Location = new System.Drawing.Point(0, 35);
            this.boxServerPlaceholder.Name = "boxServerPlaceholder";
            this.boxServerPlaceholder.Size = new System.Drawing.Size(373, 30);
            this.boxServerPlaceholder.TabIndex = 0;
            this.boxServerPlaceholder.Text = "Placeholder - SPT";
            this.boxServerPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boxServerPlaceholder.Visible = false;
            // 
            // boxPathBox
            // 
            this.boxPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxPathBox.Controls.Add(this.panel1);
            this.boxPathBox.Controls.Add(this.boxServersOpenIn);
            this.boxPathBox.Controls.Add(this.boxPath);
            this.boxPathBox.ForeColor = System.Drawing.Color.LightGray;
            this.boxPathBox.Location = new System.Drawing.Point(12, 7);
            this.boxPathBox.Name = "boxPathBox";
            this.boxPathBox.Size = new System.Drawing.Size(691, 50);
            this.boxPathBox.TabIndex = 1;
            this.boxPathBox.TabStop = false;
            this.boxPathBox.Text = " Path ";
            // 
            // boxPath
            // 
            this.boxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.boxPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxPath.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.boxPath.ForeColor = System.Drawing.Color.LightGray;
            this.boxPath.Location = new System.Drawing.Point(10, 19);
            this.boxPath.Name = "boxPath";
            this.boxPath.Size = new System.Drawing.Size(537, 20);
            this.boxPath.TabIndex = 2;
            this.boxPath.Text = "Placeholder";
            this.boxPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.boxPath_KeyDown);
            // 
            // boxServers
            // 
            this.boxServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.boxServers.AutoScroll = true;
            this.boxServers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxServers.Controls.Add(this.boxServersSeparator);
            this.boxServers.Controls.Add(this.boxServersTitle);
            this.boxServers.Controls.Add(this.boxServerPlaceholder);
            this.boxServers.Location = new System.Drawing.Point(12, 73);
            this.boxServers.Name = "boxServers";
            this.boxServers.Size = new System.Drawing.Size(375, 404);
            this.boxServers.TabIndex = 2;
            // 
            // boxServersSeparator
            // 
            this.boxServersSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxServersSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxServersSeparator.Location = new System.Drawing.Point(0, 34);
            this.boxServersSeparator.Name = "boxServersSeparator";
            this.boxServersSeparator.Size = new System.Drawing.Size(373, 1);
            this.boxServersSeparator.TabIndex = 4;
            // 
            // boxServersTitle
            // 
            this.boxServersTitle.AutoSize = true;
            this.boxServersTitle.Location = new System.Drawing.Point(3, 8);
            this.boxServersTitle.Name = "boxServersTitle";
            this.boxServersTitle.Size = new System.Drawing.Size(101, 17);
            this.boxServersTitle.TabIndex = 3;
            this.boxServersTitle.Text = "Listed servers";
            // 
            // boxSelectedServer
            // 
            this.boxSelectedServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSelectedServer.AutoScroll = true;
            this.boxSelectedServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxSelectedServer.Controls.Add(this.boxSelectedServerSeparator);
            this.boxSelectedServer.Controls.Add(this.boxSelectedServerTitle);
            this.boxSelectedServer.Controls.Add(this.boxSelectedServerPlaceholder);
            this.boxSelectedServer.Location = new System.Drawing.Point(402, 73);
            this.boxSelectedServer.Name = "boxSelectedServer";
            this.boxSelectedServer.Size = new System.Drawing.Size(301, 404);
            this.boxSelectedServer.TabIndex = 3;
            // 
            // boxSelectedServerSeparator
            // 
            this.boxSelectedServerSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSelectedServerSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxSelectedServerSeparator.Location = new System.Drawing.Point(0, 34);
            this.boxSelectedServerSeparator.Name = "boxSelectedServerSeparator";
            this.boxSelectedServerSeparator.Size = new System.Drawing.Size(299, 1);
            this.boxSelectedServerSeparator.TabIndex = 4;
            // 
            // boxSelectedServerTitle
            // 
            this.boxSelectedServerTitle.AutoSize = true;
            this.boxSelectedServerTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxSelectedServerTitle.Location = new System.Drawing.Point(3, 8);
            this.boxSelectedServerTitle.Name = "boxSelectedServerTitle";
            this.boxSelectedServerTitle.Size = new System.Drawing.Size(115, 17);
            this.boxSelectedServerTitle.TabIndex = 3;
            this.boxSelectedServerTitle.Text = "SPT Placeholder";
            this.boxSelectedServerTitle.Click += new System.EventHandler(this.boxSelectedServerTitle_Click);
            this.boxSelectedServerTitle.MouseEnter += new System.EventHandler(this.boxSelectedServerTitle_MouseEnter);
            this.boxSelectedServerTitle.MouseLeave += new System.EventHandler(this.boxSelectedServerTitle_MouseLeave);
            // 
            // boxSelectedServerPlaceholder
            // 
            this.boxSelectedServerPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSelectedServerPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.boxSelectedServerPlaceholder.Location = new System.Drawing.Point(0, 35);
            this.boxSelectedServerPlaceholder.Name = "boxSelectedServerPlaceholder";
            this.boxSelectedServerPlaceholder.Size = new System.Drawing.Size(299, 30);
            this.boxSelectedServerPlaceholder.TabIndex = 0;
            this.boxSelectedServerPlaceholder.Text = "Placeholder Item";
            this.boxSelectedServerPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boxSelectedServerPlaceholder.Visible = false;
            // 
            // boxServersOpenIn
            // 
            this.boxServersOpenIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxServersOpenIn.AutoSize = true;
            this.boxServersOpenIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxServersOpenIn.Location = new System.Drawing.Point(565, 19);
            this.boxServersOpenIn.Name = "boxServersOpenIn";
            this.boxServersOpenIn.Size = new System.Drawing.Size(116, 17);
            this.boxServersOpenIn.TabIndex = 5;
            this.boxServersOpenIn.Text = "Open in Explorer";
            this.boxServersOpenIn.Click += new System.EventHandler(this.boxServersOpenIn_Click);
            this.boxServersOpenIn.MouseEnter += new System.EventHandler(this.boxServersOpenIn_MouseEnter);
            this.boxServersOpenIn.MouseLeave += new System.EventHandler(this.boxServersOpenIn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(553, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 26);
            this.panel1.TabIndex = 5;
            // 
            // bResetApp
            // 
            this.bResetApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bResetApp.AutoSize = true;
            this.bResetApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bResetApp.Font = new System.Drawing.Font("Bahnschrift Light", 7F);
            this.bResetApp.ForeColor = System.Drawing.Color.DarkGray;
            this.bResetApp.Location = new System.Drawing.Point(676, 478);
            this.bResetApp.Name = "bResetApp";
            this.bResetApp.Size = new System.Drawing.Size(30, 12);
            this.bResetApp.TabIndex = 4;
            this.bResetApp.Text = "Reset";
            this.bResetApp.Click += new System.EventHandler(this.bResetApp_Click);
            this.bResetApp.MouseEnter += new System.EventHandler(this.bResetApp_MouseEnter);
            this.bResetApp.MouseLeave += new System.EventHandler(this.bResetApp_MouseLeave);
            // 
            // mainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(715, 494);
            this.Controls.Add(this.bResetApp);
            this.Controls.Add(this.boxSelectedServer);
            this.Controls.Add(this.boxServers);
            this.Controls.Add(this.boxPathBox);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(731, 533);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini SPT Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainForm_DragEnter);
            this.boxPathBox.ResumeLayout(false);
            this.boxPathBox.PerformLayout();
            this.boxServers.ResumeLayout(false);
            this.boxServers.PerformLayout();
            this.boxSelectedServer.ResumeLayout(false);
            this.boxSelectedServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox boxPathBox;
        private System.Windows.Forms.TextBox boxPath;
        private System.Windows.Forms.Label boxServerPlaceholder;
        private System.Windows.Forms.Panel boxServers;
        private System.Windows.Forms.Label boxServersTitle;
        private System.Windows.Forms.Panel boxServersSeparator;
        private System.Windows.Forms.Panel boxSelectedServer;
        private System.Windows.Forms.Panel boxSelectedServerSeparator;
        private System.Windows.Forms.Label boxSelectedServerTitle;
        private System.Windows.Forms.Label boxSelectedServerPlaceholder;
        private System.Windows.Forms.Label boxServersOpenIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bResetApp;
    }
}

