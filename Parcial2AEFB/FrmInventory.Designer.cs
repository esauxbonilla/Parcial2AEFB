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
            this.Quantity = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(110, 195);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 20);
            this.Quantity.TabIndex = 49;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(110, 336);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Código";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 268);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Precio";
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(55, 202);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(49, 13);
            this.LblQuantity.TabIndex = 44;
            this.LblQuantity.Text = "Cantidad";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(124, 122);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(100, 20);
            this.TxtDescription.TabIndex = 43;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(55, 125);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(63, 13);
            this.LblDescription.TabIndex = 42;
            this.LblDescription.Text = "Descripción";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(55, 48);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 13);
            this.LblName.TabIndex = 40;
            this.LblName.Text = "Nombre";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(124, 45);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 50;
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblName);
            this.Name = "FrmInventory";
            this.Text = "FrmInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
    }
}