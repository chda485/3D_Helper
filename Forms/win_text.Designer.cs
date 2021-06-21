namespace _3D_helper
{
    partial class win_text
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
            this.box_for_text = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // home_button
            // 
            this.home_button.FlatAppearance.BorderSize = 0;
            // 
            // exit_button
            // 
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.Location = new System.Drawing.Point(742, 565);
            this.exit_button.Size = new System.Drawing.Size(43, 47);
            // 
            // inscription
            // 
            this.inscription.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // nextp_button
            // 
            this.nextp_button.FlatAppearance.BorderSize = 0;
            // 
            // prevp_button
            // 
            this.prevp_button.FlatAppearance.BorderSize = 0;
            this.prevp_button.Click += new System.EventHandler(this.Prevp_button_Click);
            // 
            // box_for_text
            // 
            this.box_for_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.box_for_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.box_for_text.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_for_text.Location = new System.Drawing.Point(15, 131);
            this.box_for_text.Name = "box_for_text";
            this.box_for_text.ReadOnly = true;
            this.box_for_text.Size = new System.Drawing.Size(753, 428);
            this.box_for_text.TabIndex = 0;
            this.box_for_text.Text = "";
            this.box_for_text.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.Box_for_text_LinkClicked);
            // 
            // win_text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.box_for_text);
            this.Name = "win_text";
            this.Controls.SetChildIndex(this.modeling_button, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.printing_button, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.inscription, 0);
            this.Controls.SetChildIndex(this.box_for_text, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.exit_button, 0);
            this.Controls.SetChildIndex(this.home_button, 0);
            this.Controls.SetChildIndex(this.nextp_button, 0);
            this.Controls.SetChildIndex(this.prevp_button, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox box_for_text;
    }
}