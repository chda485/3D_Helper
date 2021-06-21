namespace _3D_helper
{
    partial class modeling_win
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
            this.formats_button = new System.Windows.Forms.Button();
            this.his3DMod = new System.Windows.Forms.Button();
            this.programms_button = new System.Windows.Forms.Button();
            this.links_model = new System.Windows.Forms.Button();
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Size = new System.Drawing.Size(784, 615);
            // 
            // nextp_button
            // 
            this.nextp_button.FlatAppearance.BorderSize = 0;
            // 
            // prevp_button
            // 
            this.prevp_button.FlatAppearance.BorderSize = 0;
            // 
            // formats_button
            // 
            this.formats_button.AutoSize = true;
            this.formats_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formats_button.ForeColor = System.Drawing.Color.Blue;
            this.formats_button.Location = new System.Drawing.Point(145, 275);
            this.formats_button.Name = "formats_button";
            this.formats_button.Size = new System.Drawing.Size(494, 76);
            this.formats_button.TabIndex = 7;
            this.formats_button.Text = "Основные форматы файлов 3D";
            this.formats_button.UseVisualStyleBackColor = true;
            this.formats_button.Click += new System.EventHandler(this.Formats_button_Click);
            // 
            // his3DMod
            // 
            this.his3DMod.AutoSize = true;
            this.his3DMod.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.his3DMod.ForeColor = System.Drawing.Color.Blue;
            this.his3DMod.Location = new System.Drawing.Point(145, 155);
            this.his3DMod.Name = "his3DMod";
            this.his3DMod.Size = new System.Drawing.Size(494, 76);
            this.his3DMod.TabIndex = 8;
            this.his3DMod.Text = "История 3D-моделирования";
            this.his3DMod.UseVisualStyleBackColor = true;
            // 
            // programms_button
            // 
            this.programms_button.AutoSize = true;
            this.programms_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programms_button.ForeColor = System.Drawing.Color.Blue;
            this.programms_button.Location = new System.Drawing.Point(145, 393);
            this.programms_button.Name = "programms_button";
            this.programms_button.Size = new System.Drawing.Size(494, 76);
            this.programms_button.TabIndex = 9;
            this.programms_button.Text = "Программы для 3D-моделирования";
            this.programms_button.UseVisualStyleBackColor = true;
            this.programms_button.Click += new System.EventHandler(this.Programms_button_Click);
            // 
            // links_model
            // 
            this.links_model.AutoSize = true;
            this.links_model.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.links_model.ForeColor = System.Drawing.Color.Blue;
            this.links_model.Location = new System.Drawing.Point(145, 505);
            this.links_model.Name = "links_model";
            this.links_model.Size = new System.Drawing.Size(494, 76);
            this.links_model.TabIndex = 10;
            this.links_model.Text = "Полезные ссылки";
            this.links_model.UseVisualStyleBackColor = true;
            this.links_model.Click += new System.EventHandler(this.Links_model_Click);
            // 
            // modeling_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.links_model);
            this.Controls.Add(this.programms_button);
            this.Controls.Add(this.his3DMod);
            this.Controls.Add(this.formats_button);
            this.Name = "modeling_win";
            this.Controls.SetChildIndex(this.prevp_button, 0);
            this.Controls.SetChildIndex(this.printing_button, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.modeling_button, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.nextp_button, 0);
            this.Controls.SetChildIndex(this.inscription, 0);
            this.Controls.SetChildIndex(this.formats_button, 0);
            this.Controls.SetChildIndex(this.his3DMod, 0);
            this.Controls.SetChildIndex(this.programms_button, 0);
            this.Controls.SetChildIndex(this.links_model, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.exit_button, 0);
            this.Controls.SetChildIndex(this.home_button, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button formats_button;
        protected System.Windows.Forms.Button his3DMod;
        protected System.Windows.Forms.Button programms_button;
        protected System.Windows.Forms.Button links_model;
    }
}