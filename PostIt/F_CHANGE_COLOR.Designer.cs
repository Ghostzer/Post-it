namespace PostIt
{
    partial class F_CHANGE_COLOR
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.Lbl_opacity = new System.Windows.Forms.Label();
            this.Tb_opacity = new System.Windows.Forms.TrackBar();
            this.Btn_closeChangeColor = new System.Windows.Forms.Button();
            this.pan_Violet = new System.Windows.Forms.Panel();
            this.pan_GreenYellow = new System.Windows.Forms.Panel();
            this.pan_LigthSkyBlue = new System.Windows.Forms.Panel();
            this.pan_Khaki = new System.Windows.Forms.Panel();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tb_opacity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.Lbl_opacity);
            this.panel_main.Controls.Add(this.Tb_opacity);
            this.panel_main.Controls.Add(this.Btn_closeChangeColor);
            this.panel_main.Controls.Add(this.pan_Violet);
            this.panel_main.Controls.Add(this.pan_GreenYellow);
            this.panel_main.Controls.Add(this.pan_LigthSkyBlue);
            this.panel_main.Controls.Add(this.pan_Khaki);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(301, 246);
            this.panel_main.TabIndex = 7;
            // 
            // Lbl_opacity
            // 
            this.Lbl_opacity.AutoSize = true;
            this.Lbl_opacity.Location = new System.Drawing.Point(117, 142);
            this.Lbl_opacity.Name = "Lbl_opacity";
            this.Lbl_opacity.Size = new System.Drawing.Size(43, 13);
            this.Lbl_opacity.TabIndex = 13;
            this.Lbl_opacity.Text = "Opacity";
            // 
            // Tb_opacity
            // 
            this.Tb_opacity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tb_opacity.LargeChange = 2;
            this.Tb_opacity.Location = new System.Drawing.Point(23, 94);
            this.Tb_opacity.Minimum = 2;
            this.Tb_opacity.Name = "Tb_opacity";
            this.Tb_opacity.Size = new System.Drawing.Size(258, 45);
            this.Tb_opacity.TabIndex = 12;
            this.Tb_opacity.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Tb_opacity.Value = 10;
            this.Tb_opacity.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged_1);
            // 
            // Btn_closeChangeColor
            // 
            this.Btn_closeChangeColor.Location = new System.Drawing.Point(110, 211);
            this.Btn_closeChangeColor.Name = "Btn_closeChangeColor";
            this.Btn_closeChangeColor.Size = new System.Drawing.Size(75, 23);
            this.Btn_closeChangeColor.TabIndex = 11;
            this.Btn_closeChangeColor.Text = "Appliquer";
            this.Btn_closeChangeColor.UseVisualStyleBackColor = true;
            this.Btn_closeChangeColor.Click += new System.EventHandler(this.Btn_closeChangeColor_Click);
            // 
            // pan_Violet
            // 
            this.pan_Violet.BackColor = System.Drawing.Color.Thistle;
            this.pan_Violet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_Violet.Location = new System.Drawing.Point(231, 26);
            this.pan_Violet.Name = "pan_Violet";
            this.pan_Violet.Size = new System.Drawing.Size(50, 50);
            this.pan_Violet.TabIndex = 10;
            this.pan_Violet.Click += new System.EventHandler(this.pan_Violet_Click);
            // 
            // pan_GreenYellow
            // 
            this.pan_GreenYellow.BackColor = System.Drawing.Color.LightGreen;
            this.pan_GreenYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_GreenYellow.Location = new System.Drawing.Point(165, 26);
            this.pan_GreenYellow.Name = "pan_GreenYellow";
            this.pan_GreenYellow.Size = new System.Drawing.Size(50, 50);
            this.pan_GreenYellow.TabIndex = 9;
            this.pan_GreenYellow.Click += new System.EventHandler(this.pan_GreenYellow_Click);
            // 
            // pan_LigthSkyBlue
            // 
            this.pan_LigthSkyBlue.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pan_LigthSkyBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_LigthSkyBlue.Location = new System.Drawing.Point(95, 26);
            this.pan_LigthSkyBlue.Name = "pan_LigthSkyBlue";
            this.pan_LigthSkyBlue.Size = new System.Drawing.Size(50, 50);
            this.pan_LigthSkyBlue.TabIndex = 8;
            this.pan_LigthSkyBlue.Click += new System.EventHandler(this.pan_LigthSkyBlue_Click);
            // 
            // pan_Khaki
            // 
            this.pan_Khaki.BackColor = System.Drawing.Color.Khaki;
            this.pan_Khaki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pan_Khaki.Location = new System.Drawing.Point(23, 26);
            this.pan_Khaki.Name = "pan_Khaki";
            this.pan_Khaki.Size = new System.Drawing.Size(50, 50);
            this.pan_Khaki.TabIndex = 7;
            this.pan_Khaki.Click += new System.EventHandler(this.pan_Khaki_Click);
            // 
            // F_CHANGE_COLOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 246);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "F_CHANGE_COLOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Séléctionnez une couleur";
            this.Load += new System.EventHandler(this.F_CHANGE_COLOR_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tb_opacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TrackBar Tb_opacity;
        private System.Windows.Forms.Button Btn_closeChangeColor;
        private System.Windows.Forms.Panel pan_Violet;
        private System.Windows.Forms.Panel pan_GreenYellow;
        private System.Windows.Forms.Panel pan_LigthSkyBlue;
        private System.Windows.Forms.Panel pan_Khaki;
        private System.Windows.Forms.Label Lbl_opacity;
    }
}