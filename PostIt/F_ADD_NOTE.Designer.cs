namespace PostIt
{
    partial class F_ADD_NOTE
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
            this.txt_contenu = new System.Windows.Forms.RichTextBox();
            this.Btn_addPostit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_contenu
            // 
            this.txt_contenu.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contenu.Location = new System.Drawing.Point(10, 14);
            this.txt_contenu.Name = "txt_contenu";
            this.txt_contenu.Size = new System.Drawing.Size(221, 179);
            this.txt_contenu.TabIndex = 4;
            this.txt_contenu.Text = "";
            // 
            // Btn_addPostit
            // 
            this.Btn_addPostit.Location = new System.Drawing.Point(84, 214);
            this.Btn_addPostit.Name = "Btn_addPostit";
            this.Btn_addPostit.Size = new System.Drawing.Size(75, 23);
            this.Btn_addPostit.TabIndex = 3;
            this.Btn_addPostit.Text = "Ajouter";
            this.Btn_addPostit.UseVisualStyleBackColor = true;
            this.Btn_addPostit.Click += new System.EventHandler(this.Btn_addPostit_Click);
            // 
            // F_ADD_NOTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 251);
            this.Controls.Add(this.txt_contenu);
            this.Controls.Add(this.Btn_addPostit);
            this.Name = "F_ADD_NOTE";
            this.Text = "Ajouter un Post-It";
            this.Deactivate += new System.EventHandler(this.F_ADD_NOTE_Deactivate);
            this.Leave += new System.EventHandler(this.F_ADD_NOTE_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_contenu;
        private System.Windows.Forms.Button Btn_addPostit;
    }
}