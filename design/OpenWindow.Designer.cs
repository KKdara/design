namespace design
{
    partial class OpenWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginTextAutho = new System.Windows.Forms.TextBox();
            this.PasswordTextAutho = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(889, 647);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginTextAutho
            // 
            this.LoginTextAutho.BackColor = System.Drawing.Color.FloralWhite;
            this.LoginTextAutho.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextAutho.ForeColor = System.Drawing.Color.DimGray;
            this.LoginTextAutho.Location = new System.Drawing.Point(192, 286);
            this.LoginTextAutho.Multiline = true;
            this.LoginTextAutho.Name = "LoginTextAutho";
            this.LoginTextAutho.Size = new System.Drawing.Size(502, 40);
            this.LoginTextAutho.TabIndex = 1;
            this.LoginTextAutho.Text = "Электронная почта";
            this.LoginTextAutho.Click += new System.EventHandler(this.LoginText_Click);
            // 
            // PasswordTextAutho
            // 
            this.PasswordTextAutho.BackColor = System.Drawing.Color.FloralWhite;
            this.PasswordTextAutho.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextAutho.ForeColor = System.Drawing.Color.DimGray;
            this.PasswordTextAutho.Location = new System.Drawing.Point(192, 365);
            this.PasswordTextAutho.Multiline = true;
            this.PasswordTextAutho.Name = "PasswordTextAutho";
            this.PasswordTextAutho.Size = new System.Drawing.Size(502, 40);
            this.PasswordTextAutho.TabIndex = 2;
            this.PasswordTextAutho.Text = "Пароль";
            this.PasswordTextAutho.Click += new System.EventHandler(this.PasswordText_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.FloralWhite;
            this.RegistrationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButton.ForeColor = System.Drawing.Color.DimGray;
            this.RegistrationButton.Location = new System.Drawing.Point(318, 564);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(269, 42);
            this.RegistrationButton.TabIndex = 4;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.FloralWhite;
            this.LogInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogInButton.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInButton.ForeColor = System.Drawing.Color.DimGray;
            this.LogInButton.Location = new System.Drawing.Point(331, 426);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(221, 44);
            this.LogInButton.TabIndex = 3;
            this.LogInButton.Text = "Войти";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(192, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 67);
            this.label1.TabIndex = 5;
            this.label1.Text = "Твой дом там, где ты";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(294, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Нет аккаунта? Создай!";
            // 
            // OpenWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordTextAutho);
            this.Controls.Add(this.LoginTextAutho);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "OpenWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LoginTextAutho;
        private System.Windows.Forms.TextBox PasswordTextAutho;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

