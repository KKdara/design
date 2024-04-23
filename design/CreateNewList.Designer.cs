namespace design
{
    partial class CreateNewList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewList));
            this.Picture5 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.Label();
            this.CreateCollectionButton = new System.Windows.Forms.Button();
            this.CollectionNameText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture5)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture5
            // 
            this.Picture5.Image = ((System.Drawing.Image)(resources.GetObject("Picture5.Image")));
            this.Picture5.Location = new System.Drawing.Point(-2, 0);
            this.Picture5.Name = "Picture5";
            this.Picture5.Size = new System.Drawing.Size(753, 208);
            this.Picture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture5.TabIndex = 0;
            this.Picture5.TabStop = false;
            // 
            // Text1
            // 
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            this.Text1.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Text1.Location = new System.Drawing.Point(174, 25);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(453, 47);
            this.Text1.TabIndex = 8;
            this.Text1.Text = "Создать новую подборку";
            // 
            // Text2
            // 
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Text2.Location = new System.Drawing.Point(89, 86);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(178, 39);
            this.Text2.TabIndex = 9;
            this.Text2.Text = "Название\r\n\r\n";
            // 
            // CreateCollectionButton
            // 
            this.CreateCollectionButton.BackColor = System.Drawing.Color.FloralWhite;
            this.CreateCollectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateCollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCollectionButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCollectionButton.ForeColor = System.Drawing.Color.DimGray;
            this.CreateCollectionButton.Location = new System.Drawing.Point(275, 146);
            this.CreateCollectionButton.Name = "CreateCollectionButton";
            this.CreateCollectionButton.Size = new System.Drawing.Size(213, 38);
            this.CreateCollectionButton.TabIndex = 16;
            this.CreateCollectionButton.Text = "СОЗДАТЬ\r\n\r\n";
            this.CreateCollectionButton.UseVisualStyleBackColor = false;
            // 
            // CollectionNameText
            // 
            this.CollectionNameText.BackColor = System.Drawing.Color.FloralWhite;
            this.CollectionNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CollectionNameText.Location = new System.Drawing.Point(296, 86);
            this.CollectionNameText.Multiline = true;
            this.CollectionNameText.Name = "CollectionNameText";
            this.CollectionNameText.Size = new System.Drawing.Size(382, 39);
            this.CollectionNameText.TabIndex = 17;
            // 
            // CreateNewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 207);
            this.Controls.Add(this.CollectionNameText);
            this.Controls.Add(this.CreateCollectionButton);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Picture5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CreateNewList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Picture5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture5;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Button CreateCollectionButton;
        private System.Windows.Forms.TextBox CollectionNameText;
    }
}