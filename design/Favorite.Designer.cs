namespace design
{
    partial class Favorite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorite));
            this.Picture6 = new System.Windows.Forms.PictureBox();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.FavButton = new System.Windows.Forms.Button();
            this.BlackListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture6)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture6
            // 
            this.Picture6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Picture6.Image = ((System.Drawing.Image)(resources.GetObject("Picture6.Image")));
            this.Picture6.Location = new System.Drawing.Point(-5, 0);
            this.Picture6.Name = "Picture6";
            this.Picture6.Size = new System.Drawing.Size(797, 680);
            this.Picture6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture6.TabIndex = 1;
            this.Picture6.TabStop = false;
            // 
            // ProfileButton
            // 
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(146, 9);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(61, 61);
            this.ProfileButton.TabIndex = 8;
            this.ProfileButton.UseVisualStyleBackColor = true;
            // 
            // FavButton
            // 
            this.FavButton.Image = ((System.Drawing.Image)(resources.GetObject("FavButton.Image")));
            this.FavButton.Location = new System.Drawing.Point(233, 6);
            this.FavButton.Name = "FavButton";
            this.FavButton.Size = new System.Drawing.Size(70, 64);
            this.FavButton.TabIndex = 9;
            this.FavButton.UseVisualStyleBackColor = true;
            // 
            // BlackListButton
            // 
            this.BlackListButton.Image = ((System.Drawing.Image)(resources.GetObject("BlackListButton.Image")));
            this.BlackListButton.Location = new System.Drawing.Point(485, 6);
            this.BlackListButton.Name = "BlackListButton";
            this.BlackListButton.Size = new System.Drawing.Size(64, 64);
            this.BlackListButton.TabIndex = 10;
            this.BlackListButton.UseVisualStyleBackColor = true;
            // 
            // Favourite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 677);
            this.Controls.Add(this.BlackListButton);
            this.Controls.Add(this.FavButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.Picture6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Favourite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Picture6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture6;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button FavButton;
        private System.Windows.Forms.Button BlackListButton;
    }
}