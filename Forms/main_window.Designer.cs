namespace _3D_helper
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label4 = new System.Windows.Forms.Label();
            this.printing_button = new System.Windows.Forms.Button();
            this.modeling_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prevp_button = new System.Windows.Forms.Button();
            this.nextp_button = new System.Windows.Forms.Button();
            this.inscription = new System.Windows.Forms.Label();
            this.home_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(377, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 409);
            this.label4.TabIndex = 5;
            // 
            // printing_button
            // 
            this.printing_button.AutoSize = true;
            this.printing_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printing_button.ForeColor = System.Drawing.Color.Blue;
            this.printing_button.Location = new System.Drawing.Point(472, 323);
            this.printing_button.Name = "printing_button";
            this.printing_button.Size = new System.Drawing.Size(271, 76);
            this.printing_button.TabIndex = 6;
            this.printing_button.Text = "3D-печать";
            this.printing_button.UseVisualStyleBackColor = true;
            this.printing_button.Click += new System.EventHandler(this.Printing_button_Click);
            // 
            // modeling_button
            // 
            this.modeling_button.AutoSize = true;
            this.modeling_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeling_button.ForeColor = System.Drawing.Color.Blue;
            this.modeling_button.Location = new System.Drawing.Point(24, 323);
            this.modeling_button.Name = "modeling_button";
            this.modeling_button.Size = new System.Drawing.Size(271, 76);
            this.modeling_button.TabIndex = 7;
            this.modeling_button.Text = "3D-моделирование";
            this.modeling_button.UseVisualStyleBackColor = true;
            this.modeling_button.Click += new System.EventHandler(this.Modeling_button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 3);
            this.label1.TabIndex = 8;
            // 
            // prevp_button
            // 
            this.prevp_button.BackgroundImage = global::_3D_helper.Properties.Resources.prevp_button;
            this.prevp_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevp_button.FlatAppearance.BorderSize = 0;
            this.prevp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevp_button.Location = new System.Drawing.Point(15, 12);
            this.prevp_button.Name = "prevp_button";
            this.prevp_button.Size = new System.Drawing.Size(55, 54);
            this.prevp_button.TabIndex = 13;
            this.prevp_button.UseVisualStyleBackColor = true;
            // 
            // nextp_button
            // 
            this.nextp_button.BackgroundImage = global::_3D_helper.Properties.Resources.extp_button;
            this.nextp_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextp_button.FlatAppearance.BorderSize = 0;
            this.nextp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextp_button.Location = new System.Drawing.Point(76, 12);
            this.nextp_button.Name = "nextp_button";
            this.nextp_button.Size = new System.Drawing.Size(55, 54);
            this.nextp_button.TabIndex = 12;
            this.nextp_button.UseVisualStyleBackColor = true;
            this.nextp_button.Click += new System.EventHandler(this.Nextp_button_Click);
            // 
            // inscription
            // 
            this.inscription.BackColor = System.Drawing.Color.Transparent;
            this.inscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inscription.Font = new System.Drawing.Font("Times New Roman", 34.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inscription.ForeColor = System.Drawing.Color.Blue;
            this.inscription.Image = ((System.Drawing.Image)(resources.GetObject("inscription.Image")));
            this.inscription.Location = new System.Drawing.Point(20, 83);
            this.inscription.Name = "inscription";
            this.inscription.Size = new System.Drawing.Size(757, 55);
            this.inscription.TabIndex = 11;
            this.inscription.Text = "Добро пожаловать, 3D-печатник!";
            this.inscription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home_button
            // 
            this.home_button.BackgroundImage = global::_3D_helper.Properties.Resources.home_button;
            this.home_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Location = new System.Drawing.Point(722, 12);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(50, 54);
            this.home_button.TabIndex = 10;
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Visible = false;
            this.home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackgroundImage = global::_3D_helper.Properties.Resources.cutton_exit;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Location = new System.Drawing.Point(738, 563);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(47, 49);
            this.exit_button.TabIndex = 9;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::_3D_helper.Properties.Resources.cackground;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 613);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.prevp_button);
            this.Controls.Add(this.nextp_button);
            this.Controls.Add(this.inscription);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.modeling_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printing_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainWindow";
            this.Text = "Справочник 3D-печатника";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button printing_button;
        protected System.Windows.Forms.Button modeling_button;
        protected System.Windows.Forms.Button home_button;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button exit_button;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Label inscription;
        protected System.Windows.Forms.Button nextp_button;
        protected System.Windows.Forms.Button prevp_button;
    }
}

