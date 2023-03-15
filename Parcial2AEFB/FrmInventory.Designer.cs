namespace Parcial2AEFB
{
    partial class FrmInventory
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
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.LblCode = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.NmrQuantity = new System.Windows.Forms.NumericUpDown();
            this.NmrPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NmrQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(126, 341);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(100, 20);
            this.TxtCode.TabIndex = 48;
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCode.Location = new System.Drawing.Point(28, 341);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(59, 20);
            this.LblCode.TabIndex = 47;
            this.LblCode.Text = "Código";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(28, 279);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(53, 20);
            this.LblPrice.TabIndex = 45;
            this.LblPrice.Text = "Precio";
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(273, 92);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(73, 20);
            this.LblQuantity.TabIndex = 44;
            this.LblQuantity.Text = "Cantidad";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(126, 155);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(279, 89);
            this.TxtDescription.TabIndex = 43;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(28, 155);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(92, 20);
            this.LblDescription.TabIndex = 42;
            this.LblDescription.Text = "Descripción";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(26, 94);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(65, 20);
            this.LblName.TabIndex = 40;
            this.LblName.Text = "Nombre";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(124, 94);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 50;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(25, 26);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(166, 37);
            this.LblTitle.TabIndex = 51;
            this.LblTitle.Text = "Inventario";
            this.LblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // NmrQuantity
            // 
            this.NmrQuantity.Location = new System.Drawing.Point(368, 92);
            this.NmrQuantity.Name = "NmrQuantity";
            this.NmrQuantity.Size = new System.Drawing.Size(120, 20);
            this.NmrQuantity.TabIndex = 52;
            // 
            // NmrPrice
            // 
            this.NmrPrice.Location = new System.Drawing.Point(126, 279);
            this.NmrPrice.Name = "NmrPrice";
            this.NmrPrice.Size = new System.Drawing.Size(120, 20);
            this.NmrPrice.TabIndex = 53;
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(520, 410);
            this.Controls.Add(this.NmrPrice);
            this.Controls.Add(this.NmrQuantity);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblName);
            this.Name = "FrmInventory";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.NmrQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.NumericUpDown NmrQuantity;
        private System.Windows.Forms.NumericUpDown NmrPrice;
    }
}