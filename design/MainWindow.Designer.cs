namespace design
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Picture3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.FavButton = new System.Windows.Forms.Button();
            this.BlackListButton = new System.Windows.Forms.Button();
            this.MyListsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture3)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture3
            // 
            this.Picture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Picture3.Image = ((System.Drawing.Image)(resources.GetObject("Picture3.Image")));
            this.Picture3.Location = new System.Drawing.Point(-1, 0);
            this.Picture3.Name = "Picture3";
            this.Picture3.Size = new System.Drawing.Size(797, 680);
            this.Picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture3.TabIndex = 0;
            this.Picture3.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(214, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Возможно, вам понравится";
            // 
            // ProfileButton
            // 
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(148, 12);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(61, 61);
            this.ProfileButton.TabIndex = 7;
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // FavButton
            // 
            this.FavButton.Location = new System.Drawing.Point(239, 31);
            this.FavButton.Name = "FavButton";
            this.FavButton.Size = new System.Drawing.Size(82, 23);
            this.FavButton.TabIndex = 8;
            this.FavButton.Text = "избран";
            this.FavButton.UseVisualStyleBackColor = true;
            // 
            // BlackListButton
            // 
            this.BlackListButton.Location = new System.Drawing.Point(374, 31);
            this.BlackListButton.Name = "BlackListButton";
            this.BlackListButton.Size = new System.Drawing.Size(75, 23);
            this.BlackListButton.TabIndex = 9;
            this.BlackListButton.Text = "чс";
            this.BlackListButton.UseVisualStyleBackColor = true;
            // 
            // MyListsButton
            // 
            this.MyListsButton.Location = new System.Drawing.Point(516, 31);
            this.MyListsButton.Name = "MyListsButton";
            this.MyListsButton.Size = new System.Drawing.Size(114, 23);
            this.MyListsButton.TabIndex = 10;
            this.MyListsButton.Text = "мои подбор";
            this.MyListsButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(148, 404);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "button2";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 677);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MyListsButton);
            this.Controls.Add(this.BlackListButton);
            this.Controls.Add(this.FavButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Picture3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Picture3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button FavButton;
        private System.Windows.Forms.Button BlackListButton;
        private System.Windows.Forms.Button MyListsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackButton;
    }
}