namespace PostIt
{
    partial class ChangeColor
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
            this.pan_Khaki = new System.Windows.Forms.Panel();
            this.pan_LigthSkyBlue = new System.Windows.Forms.Panel();
            this.pan_GreenYellow = new System.Windows.Forms.Panel();
            this.pan_Violet = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pan_Khaki
            // 
            this.pan_Khaki.BackColor = System.Drawing.Color.Khaki;
            this.pan_Khaki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_Khaki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_Khaki.Location = new System.Drawing.Point(23, 24);
            this.pan_Khaki.Name = "pan_Khaki";
            this.pan_Khaki.Size = new System.Drawing.Size(50, 50);
            this.pan_Khaki.TabIndex = 1;
            this.pan_Khaki.Click += new System.EventHandler(this.pan_Khaki_Click);
            // 
            // pan_LigthSkyBlue
            // 
            this.pan_LigthSkyBlue.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pan_LigthSkyBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_LigthSkyBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_LigthSkyBlue.Location = new System.Drawing.Point(95, 24);
            this.pan_LigthSkyBlue.Name = "pan_LigthSkyBlue";
            this.pan_LigthSkyBlue.Size = new System.Drawing.Size(50, 50);
            this.pan_LigthSkyBlue.TabIndex = 2;
            this.pan_LigthSkyBlue.Click += new System.EventHandler(this.pan_LigthSkyBlue_Click);
            // 
            // pan_GreenYellow
            // 
            this.pan_GreenYellow.BackColor = System.Drawing.Color.LightGreen;
            this.pan_GreenYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_GreenYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_GreenYellow.Location = new System.Drawing.Point(165, 24);
            this.pan_GreenYellow.Name = "pan_GreenYellow";
            this.pan_GreenYellow.Size = new System.Drawing.Size(50, 50);
            this.pan_GreenYellow.TabIndex = 3;
            this.pan_GreenYellow.Click += new System.EventHandler(this.pan_GreenYellow_Click);
            // 
            // pan_Violet
            // 
            this.pan_Violet.BackColor = System.Drawing.Color.Thistle;
            this.pan_Violet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_Violet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_Violet.Location = new System.Drawing.Point(231, 24);
            this.pan_Violet.Name = "pan_Violet";
            this.pan_Violet.Size = new System.Drawing.Size(50, 50);
            this.pan_Violet.TabIndex = 4;
            this.pan_Violet.Click += new System.EventHandler(this.pan_Violet_Click);
            // 
            // ChangeColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 99);
            this.Controls.Add(this.pan_Violet);
            this.Controls.Add(this.pan_GreenYellow);
            this.Controls.Add(this.pan_LigthSkyBlue);
            this.Controls.Add(this.pan_Khaki);
            this.Name = "ChangeColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeColor";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pan_Khaki;
        private System.Windows.Forms.Panel pan_LigthSkyBlue;
        private System.Windows.Forms.Panel pan_GreenYellow;
        private System.Windows.Forms.Panel pan_Violet;
    }
}