namespace design
{
    partial class TestFirstWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestFirstWindow));
            this.Picture7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Town = new System.Windows.Forms.Label();
            this.TypeOfRealty = new System.Windows.Forms.Label();
            this.Purpose = new System.Windows.Forms.Label();
            this.TownCombo = new System.Windows.Forms.ComboBox();
            this.RealtyCombo = new System.Windows.Forms.ComboBox();
            this.PurposeCombo = new System.Windows.Forms.ComboBox();
            this.NextButtonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture7)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture7
            // 
            this.Picture7.Image = ((System.Drawing.Image)(resources.GetObject("Picture7.Image")));
            this.Picture7.Location = new System.Drawing.Point(-1, -3);
            this.Picture7.Name = "Picture7";
            this.Picture7.Size = new System.Drawing.Size(801, 386);
            this.Picture7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture7.TabIndex = 0;
            this.Picture7.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(175, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите один вариант ответа\r\n";
            // 
            // Town
            // 
            this.Town.BackColor = System.Drawing.Color.Transparent;
            this.Town.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Town.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Town.Location = new System.Drawing.Point(122, 89);
            this.Town.Name = "Town";
            this.Town.Size = new System.Drawing.Size(137, 42);
            this.Town.TabIndex = 8;
            this.Town.Text = "Город:\r\n";
            // 
            // TypeOfRealty
            // 
            this.TypeOfRealty.BackColor = System.Drawing.Color.Transparent;
            this.TypeOfRealty.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeOfRealty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TypeOfRealty.Location = new System.Drawing.Point(122, 157);
            this.TypeOfRealty.Name = "TypeOfRealty";
            this.TypeOfRealty.Size = new System.Drawing.Size(343, 42);
            this.TypeOfRealty.TabIndex = 9;
            this.TypeOfRealty.Text = "Тип недвижимости:\r\n\r\n";
            // 
            // Purpose
            // 
            this.Purpose.BackColor = System.Drawing.Color.Transparent;
            this.Purpose.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Purpose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Purpose.Location = new System.Drawing.Point(122, 237);
            this.Purpose.Name = "Purpose";
            this.Purpose.Size = new System.Drawing.Size(152, 39);
            this.Purpose.TabIndex = 10;
            this.Purpose.Text = "Для чего:\r\n\r\n";
            // 
            // TownCombo
            // 
            this.TownCombo.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TownCombo.ForeColor = System.Drawing.Color.DimGray;
            this.TownCombo.FormattingEnabled = true;
            this.TownCombo.Items.AddRange(new object[] {
            "Казань",
            "Москва"});
            this.TownCombo.Location = new System.Drawing.Point(308, 89);
            this.TownCombo.Name = "TownCombo";
            this.TownCombo.Size = new System.Drawing.Size(419, 45);
            this.TownCombo.TabIndex = 11;
            // 
            // RealtyCombo
            // 
            this.RealtyCombo.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RealtyCombo.ForeColor = System.Drawing.Color.DimGray;
            this.RealtyCombo.FormattingEnabled = true;
            this.RealtyCombo.Items.AddRange(new object[] {
            "Дом",
            "Квартира ",
            "Комната"});
            this.RealtyCombo.Location = new System.Drawing.Point(484, 154);
            this.RealtyCombo.Name = "RealtyCombo";
            this.RealtyCombo.Size = new System.Drawing.Size(243, 45);
            this.RealtyCombo.TabIndex = 12;
            // 
            // PurposeCombo
            // 
            this.PurposeCombo.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PurposeCombo.ForeColor = System.Drawing.Color.DimGray;
            this.PurposeCombo.FormattingEnabled = true;
            this.PurposeCombo.Items.AddRange(new object[] {
            "Купить",
            "Снять посуточно",
            "Снять длительно"});
            this.PurposeCombo.Location = new System.Drawing.Point(308, 234);
            this.PurposeCombo.Name = "PurposeCombo";
            this.PurposeCombo.Size = new System.Drawing.Size(419, 45);
            this.PurposeCombo.TabIndex = 13;
            // 
            // NextButtonButton
            // 
            this.NextButtonButton.BackColor = System.Drawing.Color.FloralWhite;
            this.NextButtonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextButtonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButtonButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButtonButton.ForeColor = System.Drawing.Color.DimGray;
            this.NextButtonButton.Location = new System.Drawing.Point(529, 309);
            this.NextButtonButton.Name = "NextButtonButton";
            this.NextButtonButton.Size = new System.Drawing.Size(217, 44);
            this.NextButtonButton.TabIndex = 16;
            this.NextButtonButton.Text = "ДАЛЕЕ";
            this.NextButtonButton.UseVisualStyleBackColor = false;
            // 
            // TestFirstWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.NextButtonButton);
            this.Controls.Add(this.PurposeCombo);
            this.Controls.Add(this.RealtyCombo);
            this.Controls.Add(this.TownCombo);
            this.Controls.Add(this.Purpose);
            this.Controls.Add(this.TypeOfRealty);
            this.Controls.Add(this.Town);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Picture7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TestFirstWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Picture7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Town;
        private System.Windows.Forms.Label TypeOfRealty;
        private System.Windows.Forms.Label Purpose;
        private System.Windows.Forms.ComboBox TownCombo;
        private System.Windows.Forms.ComboBox RealtyCombo;
        private System.Windows.Forms.ComboBox PurposeCombo;
        private System.Windows.Forms.Button NextButtonButton;
    }
}