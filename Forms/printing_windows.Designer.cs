namespace _3D_helper
{
    partial class printing_windows
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
            this.technologies_button = new System.Windows.Forms.Button();
            this.history_printing = new System.Windows.Forms.Button();
            this.slicers_button = new System.Windows.Forms.Button();
            this.materials_button = new System.Windows.Forms.Button();
            this.links_printing = new System.Windows.Forms.Button();
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
            this.pictureBox1.Size = new System.Drawing.Size(784, 614);
            // 
            // nextp_button
            // 
            this.nextp_button.FlatAppearance.BorderSize = 0;
            // 
            // prevp_button
            // 
            this.prevp_button.FlatAppearance.BorderSize = 0;
            // 
            // technologies_button
            // 
            this.technologies_button.AutoSize = true;
            this.technologies_button.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.technologies_button.ForeColor = System.Drawing.Color.Blue;
            this.technologies_button.Location = new System.Drawing.Point(145, 243);
            this.technologies_button.Name = "technologies_button";
            this.technologies_button.Size = new System.Drawing.Size(494, 65);
            this.technologies_button.TabIndex = 9;
            this.technologies_button.Text = "Основные технологии 3D-печати";
            this.technologies_button.UseVisualStyleBackColor = true;
            this.technologies_button.Click += new System.EventHandler(this.Technologies_button_Click);
            // 
            // history_printing
            // 
            this.history_printing.AutoSize = true;
            this.history_printing.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history_printing.ForeColor = System.Drawing.Color.Blue;
            this.history_printing.Location = new System.Drawing.Point(145, 151);
            this.history_printing.Name = "history_printing";
            this.history_printing.Size = new System.Drawing.Size(494, 65);
            this.history_printing.TabIndex = 10;
            this.history_printing.Text = "История 3D-печати";
            this.history_printing.UseVisualStyleBackColor = true;
            // 
            // slicers_button
            // 
            this.slicers_button.AutoSize = true;
            this.slicers_button.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slicers_button.ForeColor = System.Drawing.Color.Blue;
            this.slicers_button.Location = new System.Drawing.Point(145, 340);
            this.slicers_button.Name = "slicers_button";
            this.slicers_button.Size = new System.Drawing.Size(494, 64);
            this.slicers_button.TabIndex = 11;
            this.slicers_button.Text = "Программы-слайсеры";
            this.slicers_button.UseVisualStyleBackColor = true;
            this.slicers_button.Click += new System.EventHandler(this.Slicers_button_Click);
            // 
            // materials_button
            // 
            this.materials_button.AutoSize = true;
            this.materials_button.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materials_button.ForeColor = System.Drawing.Color.Blue;
            this.materials_button.Location = new System.Drawing.Point(145, 436);
            this.materials_button.Name = "materials_button";
            this.materials_button.Size = new System.Drawing.Size(494, 63);
            this.materials_button.TabIndex = 12;
            this.materials_button.Text = "Основные материалы для 3D-печати";
            this.materials_button.UseVisualStyleBackColor = true;
            this.materials_button.Click += new System.EventHandler(this.Materials_button_Click);
            // 
            // links_printing
            // 
            this.links_printing.AutoSize = true;
            this.links_printing.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.links_printing.ForeColor = System.Drawing.Color.Blue;
            this.links_printing.Location = new System.Drawing.Point(145, 528);
            this.links_printing.Name = "links_printing";
            this.links_printing.Size = new System.Drawing.Size(494, 59);
            this.links_printing.TabIndex = 13;
            this.links_printing.Text = "Полезные ссылки";
            this.links_printing.UseVisualStyleBackColor = true;
            this.links_printing.Click += new System.EventHandler(this.Links_printing_Click);
            // 
            // printing_windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.links_printing);
            this.Controls.Add(this.materials_button);
            this.Controls.Add(this.slicers_button);
            this.Controls.Add(this.history_printing);
            this.Controls.Add(this.technologies_button);
            this.Name = "printing_windows";
            this.Controls.SetChildIndex(this.nextp_button, 0);
            this.Controls.SetChildIndex(this.prevp_button, 0);
            this.Controls.SetChildIndex(this.printing_button, 0);
            this.Controls.SetChildIndex(this.modeling_button, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.inscription, 0);
            this.Controls.SetChildIndex(this.technologies_button, 0);
            this.Controls.SetChildIndex(this.history_printing, 0);
            this.Controls.SetChildIndex(this.slicers_button, 0);
            this.Controls.SetChildIndex(this.materials_button, 0);
            this.Controls.SetChildIndex(this.links_printing, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.exit_button, 0);
            this.Controls.SetChildIndex(this.home_button, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button technologies_button;
        protected System.Windows.Forms.Button history_printing;
        protected System.Windows.Forms.Button slicers_button;
        protected System.Windows.Forms.Button materials_button;
        protected System.Windows.Forms.Button links_printing;
    }
}