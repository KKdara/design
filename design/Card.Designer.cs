﻿namespace design
{
    partial class Card
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
            this.Square = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Floor = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.Label();
            this.SquareText = new System.Windows.Forms.Label();
            this.PriceText = new System.Windows.Forms.Label();
            this.FloorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.Color.Transparent;
            this.Square.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Square.ForeColor = System.Drawing.Color.DimGray;
            this.Square.Location = new System.Drawing.Point(12, 56);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(165, 45);
            this.Square.TabIndex = 9;
            this.Square.Text = "Площадь:";
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.ForeColor = System.Drawing.Color.DimGray;
            this.Price.Location = new System.Drawing.Point(12, 101);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(125, 43);
            this.Price.TabIndex = 10;
            this.Price.Text = "Цена:";
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.Transparent;
            this.Address.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Address.ForeColor = System.Drawing.Color.DimGray;
            this.Address.Location = new System.Drawing.Point(12, 9);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(125, 47);
            this.Address.TabIndex = 11;
            this.Address.Text = "Адрес:";
            // 
            // Floor
            // 
            this.Floor.BackColor = System.Drawing.Color.Transparent;
            this.Floor.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Floor.ForeColor = System.Drawing.Color.DimGray;
            this.Floor.Location = new System.Drawing.Point(12, 144);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(125, 43);
            this.Floor.TabIndex = 12;
            this.Floor.Text = "Этаж:";
            // 
            // AddressText
            // 
            this.AddressText.BackColor = System.Drawing.Color.Transparent;
            this.AddressText.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressText.ForeColor = System.Drawing.Color.DimGray;
            this.AddressText.Location = new System.Drawing.Point(143, 9);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(125, 47);
            this.AddressText.TabIndex = 13;
            // 
            // SquareText
            // 
            this.SquareText.BackColor = System.Drawing.Color.Transparent;
            this.SquareText.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareText.ForeColor = System.Drawing.Color.DimGray;
            this.SquareText.Location = new System.Drawing.Point(183, 56);
            this.SquareText.Name = "SquareText";
            this.SquareText.Size = new System.Drawing.Size(125, 47);
            this.SquareText.TabIndex = 14;
            // 
            // PriceText
            // 
            this.PriceText.BackColor = System.Drawing.Color.Transparent;
            this.PriceText.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceText.ForeColor = System.Drawing.Color.DimGray;
            this.PriceText.Location = new System.Drawing.Point(124, 101);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(125, 47);
            this.PriceText.TabIndex = 15;
            // 
            // FloorText
            // 
            this.FloorText.BackColor = System.Drawing.Color.Transparent;
            this.FloorText.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FloorText.ForeColor = System.Drawing.Color.DimGray;
            this.FloorText.Location = new System.Drawing.Point(113, 144);
            this.FloorText.Name = "FloorText";
            this.FloorText.Size = new System.Drawing.Size(125, 47);
            this.FloorText.TabIndex = 16;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(524, 199);
            this.Controls.Add(this.FloorText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.SquareText);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Square);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Card";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Square;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Floor;
        private System.Windows.Forms.Label AddressText;
        private System.Windows.Forms.Label SquareText;
        private System.Windows.Forms.Label PriceText;
        private System.Windows.Forms.Label FloorText;
    }
}