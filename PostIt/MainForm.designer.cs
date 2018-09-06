namespace PostitDemo
{
    partial class MainForm
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
            this.grpPostitSettings = new System.Windows.Forms.GroupBox();
            this.lblMessageText = new System.Windows.Forms.Label();
            this.btnCreatePostit = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.chkUrgent = new System.Windows.Forms.CheckBox();
            this.grpPostitSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPostitSettings
            // 
            this.grpPostitSettings.Controls.Add(this.chkUrgent);
            this.grpPostitSettings.Controls.Add(this.txtMessage);
            this.grpPostitSettings.Controls.Add(this.btnCreatePostit);
            this.grpPostitSettings.Controls.Add(this.lblMessageText);
            this.grpPostitSettings.Location = new System.Drawing.Point(12, 12);
            this.grpPostitSettings.Name = "grpPostitSettings";
            this.grpPostitSettings.Size = new System.Drawing.Size(227, 139);
            this.grpPostitSettings.TabIndex = 0;
            this.grpPostitSettings.TabStop = false;
            this.grpPostitSettings.Text = "Settings";
            // 
            // lblMessageText
            // 
            this.lblMessageText.AutoSize = true;
            this.lblMessageText.Location = new System.Drawing.Point(11, 29);
            this.lblMessageText.Name = "lblMessageText";
            this.lblMessageText.Size = new System.Drawing.Size(50, 13);
            this.lblMessageText.TabIndex = 0;
            this.lblMessageText.Text = "Message";
            // 
            // btnCreatePostit
            // 
            this.btnCreatePostit.Location = new System.Drawing.Point(14, 98);
            this.btnCreatePostit.Name = "btnCreatePostit";
            this.btnCreatePostit.Size = new System.Drawing.Size(75, 23);
            this.btnCreatePostit.TabIndex = 1;
            this.btnCreatePostit.Text = "Create postit";
            this.btnCreatePostit.UseVisualStyleBackColor = true;
            this.btnCreatePostit.Click += new System.EventHandler(this.btnCreatePostit_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(69, 26);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 20);
            this.txtMessage.TabIndex = 2;
            // 
            // chkUrgent
            // 
            this.chkUrgent.AutoSize = true;
            this.chkUrgent.Location = new System.Drawing.Point(14, 63);
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new System.Drawing.Size(56, 17);
            this.chkUrgent.TabIndex = 3;
            this.chkUrgent.Text = "urgent";
            this.chkUrgent.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(708, 340);
            this.Controls.Add(this.grpPostitSettings);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Postit Demo Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpPostitSettings.ResumeLayout(false);
            this.grpPostitSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPostitSettings;
        private System.Windows.Forms.CheckBox chkUrgent;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnCreatePostit;
        private System.Windows.Forms.Label lblMessageText;

    }
}

