namespace OSCMonitor
{
    partial class OSCMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSCMonitor));
            this.messageLabel = new System.Windows.Forms.Label();
            this.buttonMetrics = new System.Windows.Forms.Button();
            this.radioButtonStream = new System.Windows.Forms.RadioButton();
            this.radioButtonLast = new System.Windows.Forms.RadioButton();
            this.checkBoxUTC = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(12, 24);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(139, 13);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Listening on Port 5000 UDP";
            // 
            // buttonMetrics
            // 
            this.buttonMetrics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMetrics.Location = new System.Drawing.Point(512, 27);
            this.buttonMetrics.Name = "buttonMetrics";
            this.buttonMetrics.Size = new System.Drawing.Size(74, 338);
            this.buttonMetrics.TabIndex = 1;
            this.buttonMetrics.Text = "button to use for height metrics";
            this.buttonMetrics.UseVisualStyleBackColor = true;
            this.buttonMetrics.Visible = false;
            // 
            // radioButtonStream
            // 
            this.radioButtonStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonStream.AutoSize = true;
            this.radioButtonStream.Location = new System.Drawing.Point(826, 348);
            this.radioButtonStream.Name = "radioButtonStream";
            this.radioButtonStream.Size = new System.Drawing.Size(58, 17);
            this.radioButtonStream.TabIndex = 2;
            this.radioButtonStream.Text = "Stream";
            this.radioButtonStream.UseVisualStyleBackColor = true;
            this.radioButtonStream.CheckedChanged += new System.EventHandler(this.radioButtonStream_CheckedChanged);
            // 
            // radioButtonLast
            // 
            this.radioButtonLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLast.AutoSize = true;
            this.radioButtonLast.Checked = true;
            this.radioButtonLast.Location = new System.Drawing.Point(826, 325);
            this.radioButtonLast.Name = "radioButtonLast";
            this.radioButtonLast.Size = new System.Drawing.Size(75, 17);
            this.radioButtonLast.TabIndex = 3;
            this.radioButtonLast.TabStop = true;
            this.radioButtonLast.Text = "Last Value";
            this.radioButtonLast.UseVisualStyleBackColor = true;
            this.radioButtonLast.CheckedChanged += new System.EventHandler(this.radioButtonLast_CheckedChanged);
            // 
            // checkBoxUTC
            // 
            this.checkBoxUTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUTC.AutoSize = true;
            this.checkBoxUTC.Location = new System.Drawing.Point(826, 302);
            this.checkBoxUTC.Name = "checkBoxUTC";
            this.checkBoxUTC.Size = new System.Drawing.Size(48, 17);
            this.checkBoxUTC.TabIndex = 4;
            this.checkBoxUTC.Text = "UTC";
            this.checkBoxUTC.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem1.Text = "About";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // OSCMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 377);
            this.Controls.Add(this.checkBoxUTC);
            this.Controls.Add(this.radioButtonLast);
            this.Controls.Add(this.radioButtonStream);
            this.Controls.Add(this.buttonMetrics);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OSCMonitor";
            this.Text = "OSC Monitor";
            this.Load += new System.EventHandler(this.OSCMonitor_Load);
            this.Resize += new System.EventHandler(this.OSCMonitor_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button buttonMetrics;
        private System.Windows.Forms.RadioButton radioButtonStream;
        private System.Windows.Forms.RadioButton radioButtonLast;
        private System.Windows.Forms.CheckBox checkBoxUTC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

